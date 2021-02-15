using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class AccountManager
    {
        public static string GetMyUsername()
        {
            string str = string.Empty;
            try
            {
                str = Environment.UserName;
                return str;
            }
            catch (Exception e)
            {
                str = "Unable to get username." + Environment.NewLine +
                       "Error" + Environment.NewLine +
                       "Message:  " + e.Message + Environment.NewLine +
                       "Source:  " + e.Source + Environment.NewLine +
                       "StackTrace:  " + e.StackTrace + Environment.NewLine +
                       "Inner Exception:  " + e.InnerException + Environment.NewLine;

                return MethodProperties.MethodName() + ":  " + str;
            }
        }
    }
}
