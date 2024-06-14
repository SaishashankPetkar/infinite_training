using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace que1_14_06_24
{
    class que1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter value 1 for comparison");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter value 2 for comparison");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(x == y ? $"The values {x} and {y} are equal" : $"The values {x} and {y} are not equal");
            Console.Read();
            
        }
    }
}
