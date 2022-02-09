﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare string array of names
            string[] names = { "Mary", "Joseph", "Michael", "Sarah", "Margaret", "John" };

            //Query the array of names
            var query = from n in names select (n);

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
