using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandRiskAnalyser.Rules
{
    internal class Rule
    {
        public string Command { get; set; }
        public string RiskLevel { get; set; }
        public string Description { get; set; }
    }
}
