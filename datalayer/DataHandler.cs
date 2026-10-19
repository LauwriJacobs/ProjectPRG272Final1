using System;
using System.Collections.Generic;
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
     public string path = @"animal.txt";

        public void AddAnimal(string animalid, string name, string species, string age, int recovscore, string status, string HU)
        {
            if (!File.Exists(path))
            {
                // Create the file if it doesn't exist
                using (FileStream fs = File.Create(path)) ;
            }
                // Append the new record to the file
                using (StreamWriter sw = new StreamWriter(path, append: true))
            {
                string text = $"{animalid}|{name}|{species}|{age}|{recovscore}|{status}|{HU}";
                sw.WriteLine(text);
            }

            MessageBox.Show("Data has been saved");
        }

        public void UpdateAnimal()
        {

        }


    }
}
