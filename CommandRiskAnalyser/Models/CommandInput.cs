using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandRiskAnalyser.Models
{
    internal class CommandInput
    {
        private string command;

        public CommandInput(string command)
        {
            this.command = command;
        }
        public string Command { get { return command; } }
    }
}
