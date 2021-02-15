using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class MethodProperties
    {
        public static string MethodName([CallerMemberName] string caller = null)
        {
            return (" (" + caller + ") ");
        }
    }
}
