using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_19_06_24
{
    public class que2exchangestring
    {
        public static void stringexc()
        {
            Console.Write("Enter a string whose first and last character you want to exchange : ");
            string ogstr = Console.ReadLine(); 
            char startc,endc;
            startc = ogstr[0];
            endc = ogstr[ogstr.Length - 1];
            string newstr = endc + ogstr.Substring(1, ogstr.Length - 2) + startc; 
            Console.Write("The string after character is : " + newstr);
        }
    }
}
