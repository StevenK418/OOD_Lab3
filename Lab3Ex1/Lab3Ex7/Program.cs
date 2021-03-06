using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Call Query syntax method
            UsingQuerySyntax();

            //New line to separate results
            Console.WriteLine();

            //Call the lambda syntax method
            UsingLambdaSyntax();

            //Wait for input to prevent instant console closure
            Console.ReadLine();
        }

        /// <summary>
        /// Queries a list of names using LINQ Query syntax and
        /// orders them alphabetically.
        /// </summary>
        private static void UsingQuerySyntax()
        {
            //Declare string array of names
            string[] names = { "Mary", "Joseph", "Michael", "Sarah", "Margaret", "John" };

            //Query the array of names and sort alphabetically
            var query = from n in names
                orderby (n)
                select (n);

            //Iterate through result set returned via the query
            foreach (var name in query)
            {
                //Print the element in the set
                Console.WriteLine(name);
            }
        }

        /// <summary>
        /// Queries a list of names using LINQ Lambda syntax and
        /// orders them alphabetically.
        /// </summary>
        private static void UsingLambdaSyntax()
        {
            //Declare string array of names
            string[] names = { "Mary", "Joseph", "Michael", "Sarah", "Margaret", "John" };

            //Query the array of names and sort alphabetically
            var query = names.OrderBy(n => n).Select(n => n);

            //Iterate through result set returned via the query
            foreach (var name in query)
            {
                //Print the element in the set
                Console.WriteLine(name);
            }
        }
    }
}
