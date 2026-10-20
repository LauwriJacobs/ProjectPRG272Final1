using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPRG272Final1
{
    internal class SummeryReport
    {
        public string TotalAnimals { get; set; }
        public string AverageAge { get; set; }
        public string AverageRecoveryScore { get; set; }
        public Dictionary<string, int> StatusCounts { get; set; }
    }
}
