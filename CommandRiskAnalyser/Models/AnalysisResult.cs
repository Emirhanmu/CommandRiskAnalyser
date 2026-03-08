using CommandRiskAnalyser.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandRiskAnalyser.Models
{
    internal class AnalysisResult
    {
        private string commandInput = "Null";
        private string command = "None";
        private string riskLevel = "No Risk";
        private string description = "Safe";
        private DateTime date;

        public string CommandInput { get => commandInput; set => commandInput = value; }
        public string Command { get => command; set => command = value; }
        public DateTime Date { get => date; set => date = value; }
        public string RiskLevel { get => riskLevel; set => riskLevel = value; }
        public string Description { get => description; set => description = value; }
    }
}
