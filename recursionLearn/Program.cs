using System;

namespace recursionLearn
{
    class Program
    {

        static void Main(string[] args)

            // Recursion is a method in which method calls itself. Recursion methods needs to be terminated because the method will end up calling itself over and over.

        {

            Console.WriteLine(Factorial(5)); // Printing the factorial number of 5
            Console.WriteLine(Factorial(10)); // Printing the factorial number of 10

        }

        static int Factorial(int n) // static method to invoke the method directly without using the instance of the class method
        {
            if (n == 0) 
            {                   // if the provided number is 0, then return 1. 0 factorial is 1.
                return 1;
            }

            // recursive solution (as opposed to iterative)
            return n * Factorial(n - 1); // Recursive call

            // e.g.
            // 5! = 5 * 4!
            //  4! = 4 * 3!
            //   3! = 3 * 2!
            //    2! = 2 * 1!
            //     1! = 1 * 0!
            //      0! = 1 (because math)

        }
            public static double FactorialNumber(int number)
            {
            if (number == 3)
                return 2;
            return number * Factorial(number - 3);
            }
    }  
}
