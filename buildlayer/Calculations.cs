using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG272Group5PM.BuildLayer
{
    internal class Calculations
    {
        string status;
        string housing;
        public string CalculatorStatus(int recoveryscore)
        {

            if (recoveryscore <= 19 && recoveryscore >= 0)
            {
                status = "Critical";
            }
            else if (recoveryscore >= 20 && recoveryscore <= 39)
            {
                status = "Serious";
            }
            else if (recoveryscore >= 40 && recoveryscore <= 59)
            {
                status = "Stable";
            }
            else if (recoveryscore >= 60 && recoveryscore <= 79)
            {
                status = "Recovering";
            }
            else if (recoveryscore >= 80 && recoveryscore <= 100)
            {
                status = "Release-Ready";
            }

            return status;
        }

        public string CalculateHousing(string status)
        {
            if (status == "Critical")
            {
                housing = "Intensive Care Unit";
            }
            else if (status == "Serious")
            {
                housing = "High-Dependancy Ward";
            }
            else if (status == "Stable")
            {
                housing = "Recovery Ward";
            }
            else if (status == "Recovering")
            {
                housing = "Outdoor Enclosure";
            }
            else if (status == "Release-Ready")
            {
                housing = "Pre-Release Camp";
            }

            return housing;
        }
    }
}
