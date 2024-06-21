using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class que2
    {
        public static void assnque2()
        {
            bool validInput = false;

            while (!validInput)
            {
                Console.Write("Enter the number in range of 1 to 7 to get corresponding day of that number : ");
                int day = Convert.ToInt32(Console.ReadLine());
                switch (day)
                {
                    case 1:
                        Console.WriteLine("The day corresponding to number 1 is: Sunday");
                        validInput = true;
                        break;
                    case 2:
                        Console.WriteLine("The day corresponding to number 2 is: Monday");
                        validInput = true;
                        break;
                    case 3:
                        Console.WriteLine("The day corresponding to number 3 is: Tuesday");
                        validInput = true;
                        break;
                    case 4:
                        Console.WriteLine("The day corresponding to number 4 is: Wednesday");
                        validInput = true;
                        break;
                    case 5:
                        Console.WriteLine("The day corresponding to number 5 is: Thursday");
                        validInput = true;
                        break;
                    case 6:
                        Console.WriteLine("The day corresponding to number 6 is: Friday");
                        validInput = true;
                        break;
                    case 7:
                        Console.WriteLine("The day corresponding to number 7 is: Saturday");
                        validInput = true;
                        break;
                    default:
                        Console.WriteLine("Invalid number. Please enter a number between 1 and 7.");
                        break;
                }
            }
            Console.Read();
        }
    }
}
