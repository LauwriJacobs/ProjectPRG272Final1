using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG272Group5PM.DataLayer
{
    internal class FileHandler
    {
        
        private string path = @"animal.txt";
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




    }
}
