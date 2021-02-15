using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utilities;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine(ProcessManager.KillProcesses("Excel"));
        }

        [TestMethod]
        public void TestMethod2()
        {

        }

        [TestMethod]
        public void TestTrace()
        {
           
            Console.WriteLine(NetworkCommands.Tracert("192.168.1.99"));
        }

        [TestMethod]
        public void TestStopWatch()
        {
            Console.WriteLine(StopWatchTimer.Start());
            Thread.Sleep(7000);
            Console.WriteLine(StopWatchTimer.Stop());
        }
    }
}
