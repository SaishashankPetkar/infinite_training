using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace que1_14_06_24
{
    class que2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter value to check positive or negative");
            int x = int.Parse(Console.ReadLine());
            if(x>-1)
            {
                Console.WriteLine($"{x} is a positve number");
            }
            else
            {
                Console.WriteLine($"{x} is a negative number");
            }
            
            Console.Read();

        }
    }
}
