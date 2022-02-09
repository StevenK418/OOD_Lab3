using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Ex9
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
        /// Queries list of customers using LINQ query syntax where Dublin is listed as the city. 
        /// </summary>
        private static void UsingQuerySyntax()
        {
            //Get all customers who Dublin listed as city
            var query = from c in GetCustomers()
                where c.City == "Dublin"
                select c;

            //Iterate through result set
            foreach (var item in query)
            {
                //Print name and city to console
                Console.WriteLine($"{item.Name} - {item.City}");
            }
        }


        /// <summary>
        /// Queries list of customers using LINQ lambda syntax where Dublin is listed as the city. 
        /// </summary>
        private static void UsingLambdaSyntax()
        {
            var results = GetCustomers();

            //Get all customers who Dublin listed as city
            var query = results
                .Where(c => c.City == "Dublin")
                .Select(c=> c);

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
