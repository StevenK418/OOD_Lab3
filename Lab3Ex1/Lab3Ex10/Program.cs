using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Ex10
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
        /// Queries the customer list using LINQ query syntax based on city and sorts by name
        /// </summary>
        private static void UsingQuerySyntax()
        {
            //Get all customers who Dublin or Galway listed as city, sort by name
            var query = from c in GetCustomers()
                where c.City == "Dublin" || c.City == "Galway"
                orderby (c.Name)
                select c;

            //Iterate through result set
            foreach (var item in query)
            {
                //Print name and city to console
                Console.WriteLine($"{item.Name} - {item.City}");
            }
        }


        /// <summary>
        /// Queries the customer list using LINQ lambda syntax based on city and sorts by name
        /// </summary>
        private static void UsingLambdaSyntax()
        {
            //Get all customers who Dublin or Galway listed as city, sort by name
            var results = GetCustomers();

            var query = results
                .Where(c => c.City == "Dublin" || c.City == "Galway")
                .OrderBy(c => c.Name)
                .Select(c => c);

            //Iterate through result set
            foreach (var item in query)
            {
                //Print name and city to console
                Console.WriteLine($"{item.Name} - {item.City}");
            }
        }

        /// <summary>
        /// Generates a new collection of customer objects
        /// </summary>
        /// <returns></returns>
        private static List<Customer> GetCustomers()
        {
            //Create a new customer List
            List<Customer> customers = new List<Customer>();

            //CReate new instances of type customer
            Customer c1 = new Customer { Name = "Tom", City = "Dublin" };
            Customer c2 = new Customer { Name = "Sally", City = "Galway" };
            Customer c3 = new Customer { Name = "George", City = "Cork" };
            Customer c4 = new Customer { Name = "Molly", City = "Dublin" };
            Customer c5 = new Customer { Name = "Joe", City = "Galway" };

            //Add the new instances to the list
            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);
            customers.Add(c4);
            customers.Add(c5);

            //Return the list
            return customers;
        }
    }
}

