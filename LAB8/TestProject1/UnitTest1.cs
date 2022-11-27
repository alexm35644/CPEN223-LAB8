//Student name:
//Student number:

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lab8.Tests
{
    [TestClass()]
    public class RootFindingTests
    {
        //Put a helper method below for each of the f(x) that you have a test case on
        //Each of these helper methods must take one parameter (type double) and must have a double return type
        double TestFunction1(double x) //a quadratic equation
        {
            return x * x + (-3) * x + 2;
        }
        double TestFunction2(double x) //the cos(x) - x^3 equation
        {
            return Math.Cos(x) - x * x * x;
        }

        [TestMethod()]
        public void BisectionTest1()
        {
            double epsilon = 0.0001;
            double a = 0.5;
            double b = 1.5;
            double result = RootFinding.Bisection(TestFunction1, a, b, epsilon);
            Assert.AreEqual(1, result, epsilon);
        }

        [TestMethod()]
        [ExpectedException(typeof(System.ArgumentException))]
        public void BisectionTest2()
        {
            RootFinding.Bisection(TestFunction2, 0.8, 0.85, 0.0001);
        }
    }
}