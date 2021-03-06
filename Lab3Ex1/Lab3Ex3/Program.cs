using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab3Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Call the Query Syntax Method
            UsingQuerySyntax();

            //New line to separate results
            Console.WriteLine();

            //Call the lambda expression syntax
            UsingLambdaSyntax();

            //Wait for input to prevent instant console closure
            Console.Read();
        }

        /// <summary>
        /// Queries a directory for file info using LINQ Query syntax and 
        /// prints this info to the console.
        /// </summary>
        public static void UsingQuerySyntax()
        {
            var files = new DirectoryInfo("c:\\Windows").GetFiles();
            var query = from item in files
                        where item.Length > 10000
                        orderby item.Length, item.Name
                        select new
                        {
                            Name = item.Name,
                            Length = item.Length,
                            CreationTime = item.CreationTime
                        };

            Console.WriteLine("FileName\tSize\t\tCreation Date");
            foreach (var item in query)
            {
                Console.WriteLine("{0} \t{1} bytes, \t{2}",
                    item.Name, item.Length, item.CreationTime);
            }
        }

        /// <summary>
        /// Queries a directory for file info using LINQ Lambda syntax and 
        /// prints this info to the console.
        /// </summary>
        private static void UsingLambdaSyntax()
        {
            var files = new DirectoryInfo("c:\\Windows").GetFiles();
            var query = files.Where(f => f.Length > 10000)
                .OrderBy(f => f.Length).ThenBy(f => f.Name)
                .Select(f => new 
                {
                    Name = f.Name,
                    Length = f.Length,
                    CreationTime = f.CreationTime
                });

            Console.WriteLine("FileName\tSize\t\tCreation Date");
            foreach (var item in query)
            {
                Console.WriteLine("{0} \t{1} bytes, \t{2}",
                    item.Name, item.Length, item.CreationTime);
            }
        }
    }
}
