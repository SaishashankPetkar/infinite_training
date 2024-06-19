using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_19_06_24
{
    public class que4multiplicationtables
    {
        public static void multiplicationtables()
        {
            Console.Write("Enter the number whose multiplication table you want to print : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"The Multipication Table for {a} is : ");
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine($"{a} * {i} = {a * i}");
            }
        }
    }
}
