using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class que1
    {
        static int sum(int x, int y)
        {
            if (x == y)
            {
                return 3 * (x + y);
            }
            else
                return x + y;
        }
        public static void assnque1()
        {
            Console.Write("Enter number 1 for sum opration :");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter number 2 for sum opration :");
            int b = int.Parse(Console.ReadLine());
            int result = sum(a, b);
            Console.WriteLine("The sum of the numbers is : " + result);
            Console.Read();

        }
    }
}
