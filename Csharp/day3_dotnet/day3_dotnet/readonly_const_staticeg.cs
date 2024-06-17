using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_dotnet
{
    class readonly_const_staticeg
    {
        //readonly variable declaration
        public readonly int myvar1=10; //assigning value to a readonly 
        public readonly string mydata;
        const float PI = 3.14f; //constant variable
        int x;
        static int y = 10;


        public readonly_const_staticeg()
        {
            Console.WriteLine(myvar1);
            myvar1 = 20;
            mydata = "Readonly variable";
            Console.WriteLine("Value of myvar is {0}, and mydata is : {1}", myvar1, mydata);

        }

        public static void Main()
        {
            readonly_const_staticeg rcs = new readonly_const_staticeg();
            Console.WriteLine(PI);
            Console.Read();
        }
    }
}
