using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class StopWatchTimer

    {
        internal static System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
        public static string Start()
        {
            string str = string.Empty;
            try
            {
                watch.Start();
                str = "Stopwatch started...";
            }
            catch (Exception e)
            {
                str = e.Message;
            }
            return str;
        }

        public static string Stop()
        {
            string str = string.Empty;
            try
            {
                watch.Stop();
                TimeSpan time = TimeSpan.FromSeconds(watch.Elapsed.TotalSeconds);
                str = "Elapsed Time (hh:mm:ss:fff):  " + time.ToString(@"hh\:mm\:ss\:fff");
            }
            catch (Exception e)
            {
                str = e.Message;
            }
            return str;
        }


        public static string Reset()
        {
            string str = string.Empty;
            try
            {
                watch.Reset();
                str = "Reset stopwatch.";
            }
            catch (Exception e)
            {
                str = e.Message;
            }
            return str;
        }
    }
}
