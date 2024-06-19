using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_19_06_24
{
    public class que3findthelargestnum
    {
        public static void largestnum()
        {
            int a , b, c;
            Console.Write("Enter number 1 to find greatest among 3 numbers: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter number 2 to find greatest among 3 numbers: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Enter number 3 to find greatest among 3 numbers: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (a>b && a>c)
            {
                Console.Write("The largest number is from the given inputs is : " + a);
            }
            else if(b>a && b>c)
            {
                Console.Write("The largest number is from the given inputs is : " + b);
            }
            else
            {
                Console.Write("The largest number is from the given inputs is : " + c);
            }
        }
    }
}
