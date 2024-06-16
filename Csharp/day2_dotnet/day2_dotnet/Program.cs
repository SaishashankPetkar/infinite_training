using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 10;
            //Console.WriteLine("X before calling a function is {0}", x);
            //callbyvalue(x); //calling 
            //Console.WriteLine("X after calling a function is {0}", x);
            //Console.WriteLine("--------------");
            //Program prog = new Program();
            //Console.WriteLine("X before calling a function is {0}", x);
            //prog.callbyref(ref x);
            //Console.WriteLine("X after calling a function is {0}", x);
            //Console.WriteLine("-------out parameter output---------");
            //int total,mul,sub,div;

            //div = calculatorfunc(15, 10, out total, out mul, out sub);
            //Console.WriteLine($"Sum is {total},Product is {mul},Divison is {div} and Difference is {sub}");
            //decisionmaking DesMak = new decisionmaking();
            //DesMak.checkgrade();
            //DesMak.checkgradewithswitch();
            //loops loop = new loops();
            //loop.whileloop();
            //loop.dowhileloop();
            //Console.WriteLine("--------for with jump statments----------------");
            //loop.forloop();
            //loop.implicittypeex();
            //arrayeg.singledimension();
            //arrayeg.twodimension();
            arrayeg.jaagedarray();

            Console.Read();

        }

        public static void callbyvalue(int j)
        {
            j = 100;
            Console.WriteLine("J is {0}", j);
        }
        public void callbyref(ref int j)
        {
            Console.WriteLine("J is {0}", j);
            j = 100;
            Console.WriteLine("J is {0}", j);

        }
        
        public static int calculatorfunc(int a, int b,out int sum,out int prod,out int diff)
        {
            sum = a + b;
            prod = a * b;
            diff = a - b;
            return a / b;
        }
    }
}
