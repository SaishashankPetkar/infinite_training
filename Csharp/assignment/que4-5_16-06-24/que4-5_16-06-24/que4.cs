using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace que4_5_16_06_24
{
    class que4
    {
        static void Main(string[] args)
        {
            int a, b, temp;
            Console.WriteLine("Enter number one to be swaped");
            a = int.Parse(Console.ReadLine()); //user input for value 1
            Console.WriteLine("Enter number two to be swaped");
            b = int.Parse(Console.ReadLine()); //user input for value 2
            Console.WriteLine($"Value of a before swap is {a} and value of b before swap is {b}"); //before swap values
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"Value of a after swap is {a} and value of b after swap is {b}"); //after swap values
            Console.Read();

        }
    }
}
