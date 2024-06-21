using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class stringque1andque2
    {
        public static void strque1andque2()
        {
            Console.Write("Enter a string whose lenght and reverse you want to find : ");
            string str = Console.ReadLine();
            int len = str.Length;
            string rev = new string(str.Reverse().ToArray());
            Console.WriteLine("The Length of entered string is : " + len);
            Console.WriteLine("The Reverse of entered string is : " + rev);
            Console.Read();
        }
    }
}
