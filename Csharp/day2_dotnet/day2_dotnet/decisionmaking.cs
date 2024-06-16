using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_dotnet
{
    class decisionmaking
    {
        public void checkgrade()
        {
            char grade;
            Console.Write("Enter your grade:");
            grade = Convert.ToChar(Console.ReadLine());
            if (grade == 'O' || grade == 'o')
                Console.WriteLine("Outstanding");
            else if (grade == 'A' || grade == 'a')
                Console.WriteLine("Excellent");
            else if (grade == 'B' || grade == 'b')
                Console.WriteLine("Very Good");
            else if (grade == 'C' || grade == 'c')
                Console.WriteLine("Can improve");
            else
                Console.WriteLine("Invalid Grade");

        }
        public void checkgradewithswitch()
        {
            Console.Write("Enter your grade: ");
            char grade = Convert.ToChar(Console.ReadLine());
            switch(grade)
            {
                case 'O':
                case 'o':
                    Console.WriteLine("Outstanding");
                    break;
                case 'a':
                case 'A':
                    Console.WriteLine("Excellent");
                    break;
                case 'b':
                case 'B':
                    Console.WriteLine("Very Good");
                    break;
                case 'C':
                case 'c':
                    Console.WriteLine("Can Improve");
                    break;
                default:
                    Console.WriteLine("Invalid Grade");
                    break;
            }
        }
    }

    class loops
    {
        public void whileloop()
        {
            int i = 1;
            while (i < 5) 
            {
                Console.WriteLine(i);
                i++;
            }
        }
        public void dowhileloop()
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 5);
        }
        public void forloop()
        {
            int total = 0;
            for(int i=1; i< 5;i++)
            {
                if (i == 3)
                    //break;
                    continue;
                total += i;
            }
            Console.WriteLine("Sum of all numbers {0}", total); ;
        }

        public void implicittypeex()
        {
            var mydata = "abv";
            Console.WriteLine(mydata);
            dynamic d;
            d = 6;
            d = 'b';
            d = "hello";
            Console.WriteLine(d);
        }
    }
}
