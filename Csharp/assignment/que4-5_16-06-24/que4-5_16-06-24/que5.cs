using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace que4_5_16_06_24
{
    class que5
    {
        static void Main() 
        {

            Console.Write("Enter a digit: ");
            string input = Console.ReadLine(); //user input

            // pattern display
            for(int i=1;i<=4;i++)
            {
                if(i%2!=0)
                {
                    Console.Write("{0} {0} {0} {0}", input);
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("{0}{0}{0}{0}", input);
                    Console.WriteLine();
                }
                    
            }
            
            Console.Read();

        }
    }
}
