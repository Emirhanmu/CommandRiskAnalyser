using CommandRiskAnalyser.Models;
using CommandRiskAnalyser.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandRiskAnalyser.Services
{
    internal class Analyser
    {
        private List<Rule> rules;

        public Analyser(List<Rule> rules) 
        {
            this.rules = rules;
        }

        public AnalysisResult Analyse(CommandInput command) 
        {
            foreach (Rule rule in rules)
            {
                if (command.Command.Contains(rule.Command))
                {
                    return new AnalysisResult()
                    {
                        CommandInput = command.Command,
                        Command = rule.Command,
                        RiskLevel = rule.RiskLevel,
                        Description = rule.Description,
                        Date = DateTime.Now,
                    };
                }
            }

            return new AnalysisResult() 
            {
                CommandInput = command.Command, 
                Date = DateTime.Now 
            };
        }
    }
}
