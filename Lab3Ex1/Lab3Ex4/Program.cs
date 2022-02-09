using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Call the Query syntax method
            UsingQuerySyntax();

            //New line to separate results
            Console.WriteLine();

            //Call the lambda syntax method
            UsingLambdaSyntax();

            //Wait for input to prevent instant console closure
            Console.ReadLine();
        }

        /// <summary>
        /// Uses LINQ query syntax to query a number array and pass
        /// each to the DoubleIT method. 
        /// </summary>
        private static void UsingQuerySyntax()
        {
            int[] numbers = { 1, 5, 3, 6, 10, 12, 8 };
            var query = from number in numbers
                        select DoubleIt(number);

            Console.WriteLine("Before the foreach loop");

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }


        /// <summary>
        /// Uses LINQ Lambda syntax to query a number array and pass
        /// each to the DoubleIT method. 
        /// </summary>
        private static void UsingLambdaSyntax()
        {
            int[] numbers = { 1, 5, 3, 6, 10, 12, 8 };
            var query = numbers
               .Select(n => DoubleIt(n));

            Console.WriteLine("Before the foreach loop");

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Doubles a given int value by multiplying by two
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Returns the result as an int</returns>
        private static int DoubleIt(int value)
        {
            Console.WriteLine("About to double the number * + value.ToString()");
            return value * 2;
        }
    }
}
