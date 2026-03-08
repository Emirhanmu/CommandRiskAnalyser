using CommandRiskAnalyser.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandRiskAnalyser.Repositories
{
    internal class RulesRepository
    {
        public static List<Rule> LoadRepos()
        {
            List<Rule> rules = new List<Rule>();
            rules.Add(new Rule 
            {
                Command = "rm -rf",
                RiskLevel = "Critical",
                Description = "Recursively deletes files and directories"
            });
            rules.Add(new Rule
            {
                Command = "rm -rf /",
                RiskLevel = "Critical",
                Description = "Deletes the entire filesystem"
            });
            rules.Add(new Rule
            {
                Command = "dd",
                RiskLevel = "Critical",
                Description = "Low level disk write command that can overwrite drives"
            });
            rules.Add(new Rule
            {
                Command = "mkfs",
                RiskLevel = "Critical",
                Description = "Formats a filesystem"
            });
            rules.Add(new Rule
            {
                Command = "mkfs.ext4",
                RiskLevel = "Critical",
                Description = "Formats a disk partition"
            });
            rules.Add(new Rule
            {
                Command = "shutdown",
                RiskLevel = "Medium",
                Description = "Shuts down the system"
            });
            rules.Add(new Rule
            {
                Command = "reboot",
                RiskLevel = "Medium",
                Description = "Reboots the system"
            });
            rules.Add(new Rule
            {
                Command = "chmod 777",
                RiskLevel = "High",
                Description = "Gives full permissions to everyone"
            });
            rules.Add(new Rule
            {
                Command = "chown",
                RiskLevel = "Medium",
                Description = "Changes file ownership"
            });
            rules.Add(new Rule
            {
                Command = "userdel",
                RiskLevel = "High",
                Description = "Deletes a system user"
            });
            rules.Add(new Rule
            {
                Command = "usermod",
                RiskLevel = "Medium",
                Description = "Modifies a user account"
            });
            rules.Add(new Rule
            {
                Command = "passwd",
                RiskLevel = "Medium",
                Description = "Changes user password"
            });
            rules.Add(new Rule
            {
                Command = "systemctl stop",
                RiskLevel = "Medium",
                Description = "Stops a running service"
            });
            rules.Add(new Rule
            {
                Command = "systemctl disable",
                RiskLevel = "Medium",
                Description = "Disables a service from starting automatically"
            });
            rules.Add(new Rule
            {
                Command = "kill -9",
                RiskLevel = "Medium",
                Description = "Force kills a running process"
            });
            rules.Add(new Rule
            {
                Command = "iptables",
                RiskLevel = "High",
                Description = "Modifies firewall rules"
            });
            rules.Add(new Rule
            {
                Command = "mount",
                RiskLevel = "Medium",
                Description = "Mounts a filesystem"
            });
            rules.Add(new Rule
            {
                Command = "umount",
                RiskLevel = "Medium",
                Description = "Unmounts a filesystem"
            });
            rules.Add(new Rule
            {
                Command = ":(){",
                RiskLevel = "Critical",
                Description = "Fork bomb that can crash the system"
            });
            return rules;
        }
    }
}
