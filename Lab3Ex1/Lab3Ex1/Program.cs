using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Call the Query syntax method
            NumbersUsingQuery();

            //New line (used to visually separate results)
            Console.WriteLine();

            //Call the Lambda syntax method
            NumbersUsingLambda();

           

            //Wait for input to avoid instant terminal close
            Console.ReadLine();

        }

        /// <summary>
        /// Uses LINQ query syntax to retrieve a given set of numbers
        /// </summary>
        private static void NumbersUsingQuery()
        {
            int[] numbers = { 1, 5, 3, 6, 11, 2, 15, 21, 13, 12, 10 };

            //Using Query syntax
            var outputNumbers = from number in numbers
                                where number > 5
                                orderby number descending
                                select number;

            foreach (int number in outputNumbers)
            {
                Console.WriteLine(number.ToString());
            }
        }

        /// <summary>
        /// Uses LINQ Lambda syntax to retrieve a given set of numbers
        /// </summary>
        private static void NumbersUsingLambda()
        {
            int[] numbers = { 1, 5, 3, 6, 11, 2, 15, 21, 13, 12, 10 };
            //Using Lambda syntax
            var outputNumbers = numbers.Where(n => n > 5)
                                .OrderByDescending(n => n);

            foreach (int number in outputNumbers)
            {
                Console.WriteLine(number.ToString());
            }
        }

        
    }
}
