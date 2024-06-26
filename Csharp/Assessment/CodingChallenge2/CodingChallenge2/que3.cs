using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge2
{
    class que3
    {
        static void check_num(int n)
        {
            if (n < 0)
            {
                throw new Exception("Please enter postive integer !");
            }
            else
            {
                Console.WriteLine("The number entered is postive ");
            }
        }
        public static void exceptioncalling()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter a number : ");
                    int num = int.Parse(Console.ReadLine());
                    check_num(num);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error :" + ex.Message);
                    Console.WriteLine();
                    Console.Write("Enter a number : ");
                    int num = int.Parse(Console.ReadLine());
                    check_num(num);
                }
                break;
            }
        }
    }
}
