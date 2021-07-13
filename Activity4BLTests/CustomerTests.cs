using Microsoft.VisualStudio.TestTools.UnitTesting;
using Activity4BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity4BL.Tests
{
    [TestClass()]
    public class CustomerTests
    {
        [TestMethod()]
        public void CustomerTest()
        {

        }

      
        [TestMethod()]
        public void CustomerTest1()
        {
            DateTime dt1 = new DateTime(2021, 07, 10);

            Customer c1 = new Customer("simran", "patna", dt1, "s@ltts.com", 1001, Gender.Female, "star98");

            DateTime dt2 = new DateTime(2020, 07, 10);
            Customer c2 = new Customer("priya", "kochi", dt2, "p@ltts.com", 1002, Gender.Female, "sun34");

            Assert.AreNotSame(c1, c2);
        }
    }
}