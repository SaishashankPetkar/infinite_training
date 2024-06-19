using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_19_06_24
{
    public class que1string
    {
        public static void stringops()
        {
            string s;
            Console.Write("Enter a string to remove the character from :");
            s = Console.ReadLine();
            Console.WriteLine($"Enter the position of character which you want to remove in the range of 0 to {s.Length - 1} where 0 is starting character of string");
            int c = int.Parse(Console.ReadLine());
            string rc = s.Remove(c,1);
            Console.WriteLine("After the character is removed the string is: "+rc);
        }
    }
}
