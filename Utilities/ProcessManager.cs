using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace Utilities
{
    public class ProcessManager
    {
        public static string KillProcesses(string ProcessName)
        {
            string str = string.Empty;
            try
            {
                IEnumerable<Process> processes = Process.GetProcesses().Where(pr => pr.ProcessName.CaseInsensitiveContains(ProcessName));
                List<Process> processesList = processes.ToList();
                if (!processesList.Any()) return null;
                foreach (Process task in processesList)
                {
                    str += "Killing " + task.ProcessName + "..." + Environment.NewLine; 
                    task.Kill();
                    str += "Done." + Environment.NewLine;
                }
                
            }
            catch (Exception e)
            {
                str += "Attempted to kill the process but received an error." + Environment.NewLine +
                       "Error" + Environment.NewLine +
                       "Message:  " + e.Message + Environment.NewLine +
                       "Source:  " + e.Source + Environment.NewLine +
                       "StackTrace:  " + e.StackTrace + Environment.NewLine +
                       "Inner Exception:  " + e.InnerException + Environment.NewLine +
                       "Process Name:  " + ProcessName + Environment.NewLine;
            }
            return MethodProperties.MethodName() + ":  " + str;
        }
    }
}
