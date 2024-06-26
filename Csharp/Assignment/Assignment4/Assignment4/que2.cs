using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class que2
    {
        public static void charoccurancecount()
        {
            Console.Write("Enter a string for character  occurance you want to count : ");
            string str = Console.ReadLine();
            Console.Write("Enter a character whose occurance you want to count : ");
            char ch = Convert.ToChar(Console.ReadLine());
            int count = 0;
            foreach(char c in str)
            {
                if (c == ch)
                {
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"The occurance of character {ch} in string {str} is {count} times.");
        }
    }
}
