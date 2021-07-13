using Microsoft.VisualStudio.TestTools.UnitTesting;
using Activity4BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Activity4BL.Category;

namespace Activity4BL.Tests
{
    [TestClass()]
    public class ProductTests
    {
        [TestMethod()]
        public void ProductTest()
        {

        }

        [TestMethod()]
        public void ProductTest1()
        {
         
            Product pr1 = new Product("Natraj", "Used for writing", 10, Category.Pencil);

            Product pr2 = new Product("Apsara", "Used for erasing", 5, Category.Eraser);

            Assert.AreNotSame(pr1, pr2);


        }
    }
}