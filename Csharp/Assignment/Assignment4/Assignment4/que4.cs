using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Scholarship
    {
        public void Merit()
        {
            Console.WriteLine("Scholarship calculation system !");
            Console.WriteLine();
            Console.Write("Enter your marks in percentage : ");
            double marks = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your fees amount : ");
            double fees = Convert.ToDouble(Console.ReadLine());
            if(marks>=70 && marks <= 80)
            {
                double scholar_amt = fees * (20.0 / 100);
                Console.WriteLine($"The scholarship amount based on your marks {marks}% is {scholar_amt}");
            }
            else if (marks >= 80 && marks <= 90)
            {
                double scholar_amt = fees * (30.0 / 100);
                Console.WriteLine($"The scholarship amount based on your marks {marks}% is {scholar_amt}");
            }
            else if (marks > 90)
            {
                double scholar_amt = fees * (50.0 / 100);
                Console.WriteLine($"The scholarship amount based on your marks {marks}% is {scholar_amt}");
            }
            else
            {
                Console.WriteLine("Sorry, You are not eligible for scholarship !");
            }
        }
    }
    class que4
    {
        public static void scholarshipcalling()
        {
            Scholarship schp = new Scholarship();
            schp.Merit();
        }
    }
}
