using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Tests
{
    [TestClass()]
    public class TaskClassTests
    {
        [TestMethod()]
        public void RandNumbTest()
        {
            var rn = TaskClass.RandNumb();
            Assert.IsTrue(rn == 1 || rn == 0);
            
        }
    }
}