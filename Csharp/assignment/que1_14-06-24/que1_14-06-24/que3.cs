using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace que1_14_06_24
{
    class que3
    {
        static void Main()
        {
            Console.WriteLine("Enter number 1 for Calculator operations");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2 for Calculator operations");
            int y = int.Parse(Console.ReadLine());

            int total, mul, sub, div;

            div = calculatorfunc(x, y, out total, out mul, out sub);
            Console.WriteLine($"Sum of {x} and {y} is {total} \n Product of {x} and {y} is {mul} \n Divison of {x} and {y} is {div} \n Difference of {x} and {y} is {sub}");
            Console.Read();
        }

        public static int calculatorfunc(int a, int b, out int sum, out int prod, out int diff)
        {
            sum = a + b;
            prod = a * b;
            diff = a - b;
            return a / b;
        }
    }
}
