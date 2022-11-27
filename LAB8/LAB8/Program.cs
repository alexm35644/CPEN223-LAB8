//Student name:
//Student number:

using System;

namespace Lab8
{
    public class Program
    {

        static void Main()
        {
            //You could mainly use unit tests for testing.       
        }

    }
    public class RootFinding
    {
        // Delegate for any function whose root we want to find
        public delegate double Function(double x);

        /// <summary>
        /// Finds a root of f() using the Bisection method.
        /// The cap for the # of attempted iterations is 300.
        /// </summary>
        /// <param name="f">A delegate representing the function f to find the root of.</param>
        /// <param name="a">Left side of (a, b) that brackets a root.</param>
        /// <param name="b">Right side of (a, b) that brackets a root. b is greater than a. </param>
        /// <param name="epsilon">The desired accuracy.</param>
        /// <returns>Returns the calculated root. If a root cannot be found, double.NaN is returned.</returns>
        /// <exception cref="ArgumentException">
        /// thrown if f(a)*f(b) is positive or 
        ///           epsilon is less than or equal to 0. 
        /// </exception>
        public static double Bisection(Function f, double a, double b, double epsilon)
        {

        }

        /// <summary>
        /// Finds a root of f() using the Secant method.
        /// </summary>
        /// <param name="f">A delegate representing the function f to find the root of.</param>
        /// <param name="x0">Initial guess x0.</param>
        /// <param name="x1">Initial guess x1 where x1 is greater than x0. </param>
        /// <param name="epsilon">The desired accuracy.</param>
        /// <returns>Returns the calculated root. </returns>
        /// <exception cref="ArgumentException">
        /// thrown if x1 is not greater than x0 or 
        ///        epsilon is less than or equal 0.
        /// </exception>
        public static double Secant(Function f, double x0, double x1, double epsilon)
        {

        }
    }
}