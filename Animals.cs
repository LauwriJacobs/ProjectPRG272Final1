using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG272Group5PM
{
    internal class Animals
    {
        public Animals(string animalid, string name, string species, string age, int recoverystat, string status, string housing)
        {
            AnimalID = animalid;
            Name = name;
            Species = species;
            Age = age;
            Recoverystat = recoverystat;
            Status = status;
            Housing = housing;
        }

        public override string ToString()
        {
            return $"{AnimalID}|{Name}|{Species}|{Age}|{Recoverystat}|{Status}|{Housing}";
        }
        //I added a comment to test the commit functionality of GitHub
        public string AnimalID { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public string Age { get; set; }
        public int Recoverystat { get; set; }
        public string Status { get; set; }
        public string Housing { get; set; }
    }
}
