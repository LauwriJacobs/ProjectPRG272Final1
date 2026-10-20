using PRG272Group5PM.BuildLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG272Group5PM.DataLayer
{
    class DataHandler
    {

        // Path to the animal data file
        public string path = @"animal.txt";

        // Method to add a new animal record to the file
        public void AddAnimal(string animalid, string name, string species, string age, int recovscore, string status, string HU)
        {
            if (!File.Exists(path))
            {
                // Create the file if it doesn't exist
                using (FileStream fs = File.Create(path));
            }
            // Append the new record to the file
            using (StreamWriter sw = new StreamWriter(path, append: true))
            {
                string text = $"{animalid}|{name}|{species}|{age}|{recovscore}|{status}|{HU}";
                sw.WriteLine(text);
            }

            MessageBox.Show("Data has been saved");
        }


        // Method to update an existing animal record in the file
        public void UpdateAnimal(string animalid, string change, string newValue)
        {

            string[] lines = File.ReadAllLines(path);

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(animalid))
                {
                    lines[i] = lines[i].Replace(change, newValue);
                    File.WriteAllLines(path, lines);

                    MessageBox.Show("Data has been updated");
                    return;
                }
            }
            MessageBox.Show("Animal not found");
        }

        // Method to delete an animal record from the file
        public void DeleteAnimal(string animalid)
        {
            List<string> lineToRemove = File.ReadAllLines(path).ToList();
            bool recordRemoved = false;

            for (int i = lineToRemove.Count() - 1; i >= 0; i--)
            {
                if (string.IsNullOrWhiteSpace(lineToRemove[i])) continue;

                string[] part = lineToRemove[i].Split('|');

                if (part.Length > 0 && part[0].Trim() == animalid.Trim())
                {
                    lineToRemove.RemoveAt(i);
                    recordRemoved = true;
                    break;
                }

            }

            if (recordRemoved)
            {
                File.WriteAllLines(path, lineToRemove);   
            }
            else
            {
                throw new Exception("Animal not found");
            }

        }

        // Method to detect and update recovery status and housing based on recovery score
        public void DetectRS()
        {
            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length < 7) continue; // expect 7 fields
                string animalid = parts[0];
                string name = parts[1];
                string species = parts[2];
                string age = parts[3];
                if (!int.TryParse(parts[4], out int recoverystat)) continue;
                string status = parts[5];
                string housing = parts[6];
                if (recoverystat > 100 || recoverystat < 0)
                {
                    MessageBox.Show($"Recovery status for animal {animalid} is out of bounds.");
                }

                string statuscheck = "";
                string housingcheck = "";

                if (int.Parse(parts[4]) <= 19 && int.Parse(parts[4]) >= 0)
                {
                    statuscheck = "Critical";
                }
                else if (int.Parse(parts[4]) >= 20 && int.Parse(parts[4]) <= 39)
                {
                    statuscheck = "Serious";
                }
                else if (int.Parse(parts[4]) >= 40 && int.Parse(parts[4]) <= 59)
                {
                    statuscheck = "Stable";
                }
                else if (int.Parse(parts[4]) >= 60 && int.Parse(parts[4]) <= 79)
                {
                    statuscheck = "Recovering";
                }
                else if (int.Parse(parts[4]) >= 80 && int.Parse(parts[4]) <= 100)
                {
                    statuscheck = "Release-Ready";
                }

                if (statuscheck == "Critical")
                {
                    housingcheck = "Intensive Care Unit";
                }
                else if (statuscheck == "Serious")
                {
                    housingcheck = "High-Dependancy Ward";
                }
                else if (statuscheck == "Stable")
                {
                    housingcheck = "Recovery Ward";
                }
                else if (statuscheck == "Recovering")
                {
                    housingcheck = "Outdoor Enclosure";
                }
                else if (statuscheck == "Release-Ready")
                {
                    housingcheck = "Pre-Release Camp";
                }

                if (!(statuscheck == status))
                {
                    UpdateAnimal(animalid, status, statuscheck);

                }
                if (!(housingcheck == housing))
                {
                    UpdateAnimal(animalid, housing, housingcheck);

                }



            }


        }
    }
}
