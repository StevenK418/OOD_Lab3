using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab3Ex2
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

        private static void UsingQuerySyntax()
        {
            var files = new DirectoryInfo("c:\\Windows").GetFiles();
            var query = from item in files
                        where item.Length > 10000
                        orderby item.Length, item.Name
                        select new MyFileInfo
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

        private static void UsingLambdaSyntax()
        {
            var files = new DirectoryInfo("c:\\Windows").GetFiles();
            var query = files.Where(f => f.Length > 10000)
                .OrderBy(f => f.Length).ThenBy(f => f.Name)
                .Select(f => new MyFileInfo
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
