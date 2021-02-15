using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Management.Automation;


namespace Utilities
{
    public class NetworkCommands
    {
        public static string PingHost(string NameOrIp)
        {
            Ping pinger = null;
            string str = string.Empty;

            bool isPingable;
            try
            {
                pinger = new Ping();
                PingReply reply = pinger.Send(NameOrIp);
                isPingable = reply.Status == IPStatus.Success;
                str = reply.Status.ToString();
            }
            catch (Exception)
            {
                isPingable = false;
            }
            finally
            {
                if (pinger != null)
                {
                    pinger.Dispose();
                }
            }
            return str;
        }


        public static string Tracert(string NameOrIp)
        {
            string str = string.Empty;
            try
            {
                ProcessStartInfo processInfo = new ProcessStartInfo
                {
                    FileName = @"cmd.exe",
                    Arguments = @"/C tracert /h 16 /w 3 /d " + NameOrIp,
                    RedirectStandardError = true,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                Process process = new Process
                {
                    StartInfo = processInfo
                };
                process.Start();

                str += process.StandardOutput.ReadToEnd();

                str += process.StandardError.ReadToEnd();

                process.Dispose();

            }
            catch (Exception e)
            {
                str += e.Message;
            }
            return str;
        }

    }
}
