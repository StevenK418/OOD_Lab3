using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare string array of names
            string[] names = { "Mary", "Joseph", "Michael", "Sarah", "Margaret", "John" };

            //Query the array of names beginning with M and sort alphabetically
            var query = from n in names
                                        where  n.StartsWith("M")
                                        orderby (n)
                                        select (n);

            //Iterate through result set returned via the query
            foreach (var name in query)
            {
                //Print the element in the set
                Console.WriteLine(name);
            }

            //Wait for input to prevent instant console closure
            Console.ReadLine();
        }
    }
}
