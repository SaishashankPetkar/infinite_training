using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4_dotnet
{
    public class Program
    {
        static int data1; //private static
        string str; //private non-static
        public float fvar; //public non-static
        public static string s; //public and static
        internal int i; //internal member
        internal static double d; //static internal member
        protected int pt;
        protected internal int ip;
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(data1 + "" + p.str+""+p.fvar+""+s);
            Console.WriteLine(d + "" + p.i+""+p.pt+""+p.ip);
            Console.Read();
        }
    }

    class driver
    {
        public static void accessprogra()
        {
            Program prg = new Program();
            prg.i = 45;
            Program.d = 55.55;
            prg.ip = 89;

        }
    }

    class programchild : Program //child of the program class
    {
        public void childacess()
        {
            Program.d = 5.5;
            Program.s = "child";
            Program p1 = new Program();
            p1.fvar = 34.5f;
            p1.i = 5;
            p1.ip = 8; //internal protected being accessed either with parent object or child object
            programchild pc = new programchild();
            pc.pt = 7; //accessing the base classes protected member with the help of derived class object
            pc.ip = 6;
        }
    }
}
