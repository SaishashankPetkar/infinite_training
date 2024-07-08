using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculateConcession;

namespace Assignment6
{
    public class Program
    {
        public const double TotalFare = 1000;
        public static void Concessioncalc()
        {
            bool desc;
            do
            {
                Console.Write("Enter your name for ticket booking : ");
                string name = Console.ReadLine();
                Console.Write("Enter your age for ticket booking : ");
                int age = int.Parse(Console.ReadLine());
                CalculateConcession.CalculateConcession concession = new CalculateConcession.CalculateConcession();
                string result = concession.Calculateconcession(age, TotalFare);
                Console.WriteLine($"Hello, {name} {result}");
                Console.Write("Do you want to another ticket (enter yes/no):");
                string ans = Console.ReadLine();
                Console.WriteLine();
                if (ans.ToLower() == "yes")
                {
                    desc = true;
                }
                else
                {
                    desc = false;
                }
            } while (desc == true);
            Console.WriteLine("Thankyou for booking ticket from us !");
        }
    }

    class que4
    {
        public static void Concessioncall()
        {
            Program.Concessioncalc();
        }
    }
}
