using Microsoft.VisualStudio.TestTools.UnitTesting;
using InsertionSort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void ExchangeTest()
        {
            int a = 2, b = 3;
            Program.Exchange(ref a, ref b);

            Assert.IsTrue((a == 3) && (b == 2));
        }
    }
}