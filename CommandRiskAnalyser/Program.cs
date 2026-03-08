using CommandRiskAnalyser.Rules;
using CommandRiskAnalyser.Models;
using CommandRiskAnalyser.Services;
using System.Security.Cryptography;
using CommandRiskAnalyser.Repositories;

namespace CommandRiskAnalyser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Rule> rules = RulesRepository.LoadRepos();

            Analyser analyser = new Analyser(rules);

            if (args.Length == 0)
            {
                Console.WriteLine("Usage: safe {command}");
            }
            else 
            {
                string command = string.Join(" ", args);

                CommandInput input = new CommandInput(command);

                AnalysisResult result = new AnalysisResult();

                result = analyser.Analyse(input);

                Console.WriteLine("User Input: " + result.CommandInput + " \nMatched Command: " + result.Command + " \nRisk Level: " + result.RiskLevel + " \nDescription: " + result.Description + " \nDate and Time: " + result.Date);
            }

            Console.ReadKey();
        }
    }
}
