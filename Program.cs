using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            string part1 = "Hello";
            string part2 = "Word";
            string space = " ";
            object textPrint = "";

            //concatenating strings
            textPrint = part1 + space + part2;

            //showing the message
            Console.WriteLine("{0}", textPrint);

            Console.ReadKey();
                
        }
    }
}
