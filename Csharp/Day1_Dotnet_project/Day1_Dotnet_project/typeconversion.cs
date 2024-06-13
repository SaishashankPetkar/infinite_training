using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Dotnet_project
{
    class typeconversion
    {
        static void Main()
        {
            int i = 100;
            Console.WriteLine("The value of int :" + i);
            float f = i; //implicite conversion
            Console.WriteLine("The value pof float:" + f);
            f = 123.45f;
            i = (int)f;  //explicit conversion using typecast
            Console.WriteLine("----------------");
            Console.WriteLine(i);
            i = Convert.ToInt32(f); //explicit conversion using conversion function
            Console.WriteLine(i);
            Console.Read();

        }
    }
}
