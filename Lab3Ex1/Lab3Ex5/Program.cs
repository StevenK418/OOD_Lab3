using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare new numbers array
            int[] numbers = { 1, 5, 3, 6, 10, 12, 8 };

            //Chain several LINQ queries together
            var query1 = numbers
                .OrderByDescending(n => n);

            var query2 = query1
                        .Where(n => n < 8);

            var query3 = query2
                        .Select(n => DoubleIt(n));

            //Iterate through result set of query 3
            foreach (var item in query3)
            {
                //Write item to the console
                Console.WriteLine(item);
            }

            var query4 = numbers
                .OrderByDescending(n => n < 8)
                .Select(n => DoubleIt(n));

            //Wait for input to avoid instant console closure
            Console.ReadLine();

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
