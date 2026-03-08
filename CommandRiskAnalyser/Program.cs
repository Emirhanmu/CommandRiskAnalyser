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

            CommandInput input = new CommandInput(Console.ReadLine());

            AnalysisResult result = new AnalysisResult();

            result = analyser.Analyse(input);

            Console.WriteLine("User Input: " + result.CommandInput + " \nMatched Command: " + result.Command + " \nRisk Level: " + result.RiskLevel + " \nDescription: " + result.Description + " \nDate and Time: " + result.Date);
            Console.ReadKey();
        }
    }
}
