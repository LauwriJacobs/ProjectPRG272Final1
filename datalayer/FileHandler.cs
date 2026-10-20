using ProjectPRG272Final1;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PRG272Group5PM.DataLayer
{
    internal class FileHandler
    {
        
        private string path = @"animal.txt";
        string sumpath = "summery.txt";

        // Method to read animal records from the file and return a list of Animals objects
        public List<Animals> readAnimals()
        {
            List<Animals> animal = new List<Animals>();

            if (!File.Exists(path)) return animal;

            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (StreamReader sr = new StreamReader(fs))
            {
                string text;
                while ((text = sr.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(text)) continue;

                    string[] parts = text.Split('|');
                    if (parts.Length < 7) continue; // expect 7 fields

                    string animalid = parts[0];
                    string name = parts[1];
                    string species = parts[2];
                    string age = parts[3];

                    if (!int.TryParse(parts[4], out int recoverystat)) continue;

                    string status = parts[5];
                    string housing = parts[6];

                    Animals newAnimal = new Animals(animalid, name, species, age, recoverystat, status, housing);
                    animal.Add(newAnimal);
                }
            }

            return animal;
        }

        // Method to generate a summary report based on the animal records in the file
        public SummeryReport GenerateSummeryReport()
        {

            SummeryReport report = new SummeryReport();
            report.StatusCounts = new Dictionary<string, int>
            {
                {"Critical", 0 },
                {"Serious", 0 },
                {"Stable", 0 },
                {"Recovering", 0 },
                {"Release-Ready", 0 }
            };

            int totalAnimals = 0;
            int totalAge = 0;
            int totalScore = 0;

            try
            {
                if (File.Exists(path))
                {
                    string[] lines = File.ReadAllLines(path);

                    foreach (string line in lines)
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;

                        string[] parts = line.Split('|');

                        if (parts.Length >= 7)
                        {
                            if (int.TryParse(parts[3], out int age) && int.TryParse(parts[4], out int score)) //out string. Outputs value into the variables
                            {
                                totalAnimals++;
                                totalAge += age;
                                totalScore += score;

                                string status = parts[5].Trim();
                                if (report.StatusCounts.ContainsKey(status))
                                {
                                    report.StatusCounts[status]++;
                                }

                            }
                            
                        }
                        
                    }
                }

                CultureInfo customCulture = CultureInfo.InvariantCulture;
                report.TotalAnimals = totalAnimals.ToString();

                if (totalAnimals > 0)
                {
                    report.AverageAge = (totalAge / (double)totalAnimals).ToString("F2", customCulture);
                    report.AverageRecoveryScore = (totalScore / (double)totalAnimals).ToString("F2", customCulture);
                }
                else
                {
                    report.AverageAge = "N/A";
                    report.AverageRecoveryScore = "N/A";
                }


                string reportLayout = $"BOABAB RIDGE WILDLIFE REHABILITATION CENTRE\n"+
                    $"ANIMAL SUMMERY REPORT\n" +
                    $"Generated: {DateTime.Now.ToString("yyyy-MM-dd HH:mm")}\n"+
                    $"----------------------------------------------------\n"+
                    $"Total Animals:            {report.TotalAnimals}\n" +
                    $"Average Age (Years):      {report.AverageAge}\n" +
                    $"Average Recovery Score:   {report.AverageRecoveryScore}\n"+
                    $"----------------------------------------------------\n" +
                    $"Animal per status:\n" +
                    $"Critical:                 {report.StatusCounts["Critical"]}\n" +
                    $"Serious:                  {report.StatusCounts["Serious"]}\n" +
                    $"Stable:                   {report.StatusCounts["Stable"]}\n" +
                    $"Recovering:               {report.StatusCounts["Recovering"]}\n" +
                    $"Release-Ready:            {report.StatusCounts["Release-Ready"]}";

                File.WriteAllText(sumpath, reportLayout);

                return report;
            }
            catch (IOException ex)
            {
                throw new Exception($"File handler system error: {ex.Message}");
            }
            
        }



    }
}
