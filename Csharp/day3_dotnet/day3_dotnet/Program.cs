using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            //stringOps();
            //struct_vs_class();
            enumrationeg.enumops();
            Console.Read();

        }

        public static void stringOps()
        {
            //strings are immutable
            string s = "hello";
            Console.WriteLine("S for the first time {0}",s.GetHashCode());
            s = "hello world";
            Console.WriteLine("S after change of value {0}", s.GetHashCode());
            string s1 = "Csharp";
            Console.WriteLine("S1 {0}", s1.GetHashCode());
            string s2 = s1; //reference of s1 is assigned to s2
            Console.WriteLine("S2 {0}", s2.GetHashCode());
            string s3 = "hello";
            Console.WriteLine("S3 {0}", s3.GetHashCode());

            //mutable string - stringbuilder
            StringBuilder sb = new StringBuilder("hello");
            Console.WriteLine("Sb's hash code : {0}",sb.GetHashCode());
            sb.Append(" World");
            Console.WriteLine("Sb's hash code : {0}", sb.GetHashCode());
            Console.WriteLine(sb);
            Console.WriteLine(sb.Capacity);
        }

        public static void struct_vs_class()
        {
            //Student s1; //or
            Student s1 = new Student(); 
            s1.mark1 = 50;
            s1.mark2 = 60;
            Console.WriteLine(s1.mark1 + s1.mark2);

            //Student s2 = new Student();
            Student s2;
            //s2 = s1; //the values are getting copied
            s2 = s1;
            //after changing struct to class,the above will copy reffrence
            Console.WriteLine(s2.mark1 + s2.mark2);

            //let us change the value 
            s1.mark1 = 80;
            s1.mark2 = 80;
            Console.WriteLine("after change....");
            Console.WriteLine(s1.mark1 + s1.mark2);
            Console.WriteLine(s2.mark1 + s2.mark2);


        }
    }
    class Student
    {
        //public fields
        public int mark1;
        public int mark2;
        //public string name;
    }
}
