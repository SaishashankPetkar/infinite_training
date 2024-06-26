using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class program
    {
        public static void flname()
        {
            Console.Write("Enter Your First Name : ");
            string f_name=Console.ReadLine();
            Console.Write("Enter Your Last Name : ");
            string l_name = Console.ReadLine();
            display(f_name, l_name);
            

        }
        static void display(string f,string l)
        {
            string upper_f = f.ToUpper(), upper_l = l.ToUpper();
            Console.WriteLine("Your First name Last name is : ");
            Console.WriteLine(upper_f);
            Console.WriteLine(upper_l);
        }
    }
    class que1
    {
        public static void flnamecall()
        {
            program.flname();
        }
       
    }
}
