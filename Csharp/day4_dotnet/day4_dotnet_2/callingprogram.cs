using System;
using day4_dotnet;

namespace day4_dotnet_2
{
    class callingprogram : Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.fvar = 500.55f; //public member of the other class accessed using the class object
            Program.s = "hh";  //static public member of the other class accessed using the classname
            callingprogram cp = new callingprogram();
            cp.pt = 18;
            cp.ip = 10;

            Console.WriteLine("First Statement");

            goto label1;
            Console.WriteLine("Second statement");

            label1:
            Console.WriteLine("You have reached lable 1");
            Console.WriteLine("will see you !..");
            Console.Read();
        }
    }
}
