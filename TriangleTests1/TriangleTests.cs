using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle.Tests
{
    [TestClass()]
    public class TriangleTests
    {

        /// </summary>
        [TestMethod()]
        public void TriangleTest()
        {
            //arrange
            double a = 3;
            double b = 4;
            double c = 5;
            Triangle t1 = new Triangle(a, b, c);

            //act
            string expecttype = "scalene";
            string actualtype;
            actualtype = t1.Type;

            //assert
            Assert.AreEqual(actualtype, expecttype);
            // Assert.Inconclusive("Validate the correction of scalene");


        }

        [TestMethod()]
        public void TriangleTest1()
        {
            //arrange
            double a = 3;
            double b = 3;
            double c = 5;
            Triangle t1 = new Triangle(a, b, c);

            //act
            string expecttype = "isosceles";
            string actualtype;
            actualtype = t1.Type;

            //assert
            Assert.AreEqual(actualtype, expecttype);
        }

        [TestMethod()]
        public void TriangleTest2()
        {
            //arrange
            double a = 3;
            double b = 3;
            double c = 3;
            Triangle t1 = new Triangle(a, b, c);

            //act
            string expecttype = "equilateral";
            string actualtype;
            actualtype = t1.Type;

            //assert
            Assert.AreEqual(actualtype, expecttype);
        }

        [TestMethod()]
        public void TriangleTest3()
        {
            //arrange
            double a = 3;
            double b = -1;
            double c = 3;
            Triangle t1 = new Triangle(a, b, c);

            //act
            string expecttype = "not a triangle";
            string actualtype;
            actualtype = t1.Type;

            //assert
            Assert.AreEqual(expecttype,actualtype);
        }
    }
}