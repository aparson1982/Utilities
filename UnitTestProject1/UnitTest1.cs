using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utilities;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine(ProcessManager.KillProcesses("excel"));
        }

        [TestMethod]
        public void TestGetUsername()
        {
            Console.WriteLine(AccountManager.GetMyUsername());
        }
    }
}
