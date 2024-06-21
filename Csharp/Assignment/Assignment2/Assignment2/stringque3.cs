using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class stringque3
    {
        public static void strque3()
        {
            Console.Write("Enter string one for comparison : ");
            string str1 = Console.ReadLine();
            Console.Write("Enter string two for comparison : ");
            string str2 = Console.ReadLine();
            Console.WriteLine();
            if (str1.Equals(str2))
            {
                Console.WriteLine("The entered strings are equal");
            }
            else
                Console.WriteLine("The entered strings are not equal");

            Console.Read();
        }
    }
}
