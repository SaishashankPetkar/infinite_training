using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4_dotnet
{
    class a1
    {
        public int i = 0;

        //method hiding
        public void Method1(string s)
        {
            Console.WriteLine("message from a1 {0}", s);
        }
    }

    class b1:a1
    {
        new int i;

        public b1(int a,int b)
        {
            base.i = a; //initializing base class member
            i = b; //initializing current class member
        }

        //method hiding
        public new void Method1(string str)
        {
            Console.WriteLine("message from b1 " + " " + str);
        }
        public void show()
        {
            Console.WriteLine("i in a1 class: "+base.i);
            Console.WriteLine("i in b1 class: " + i);
        }
    }
    class name_method_hideing
    {
        public static void Main()
        {
            b1 ob1 = new b1(25,75);
            ob1.show();
            ob1.Method1("hi");
            Console.Read();
        }
    }
}
