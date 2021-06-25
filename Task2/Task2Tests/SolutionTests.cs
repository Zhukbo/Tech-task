using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2.Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Program.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void Test()
        {
            //arrange
            int[] prices = new int[7] { 7, 2, 5, 3, 6, 4, 8 };
            int expected = 7;

            //act
            Solution obj = new Solution();
            int actual = MaxPrybutokTest(prices);
        }
    }
}

namespace Task2Tests
{
    class SolutionTests
    {
    }
}
