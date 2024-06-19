using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4_dotnet
{
    class shape
    {
        protected float R, L, B;
        //function to calculate area of shape
        public virtual float area() 
        {
            return 3.14f * R * R;
        }
    }

    class reactangle: shape
    {
        public void getlb()
        {
            Console.Write("Enter length :");
            L = float.Parse(Console.ReadLine());
            Console.Write("Enter bredth :");
            B = float.Parse(Console.ReadLine());
        }

        public override float area()
        {
            return L * B;
        }
    }
    class circle : shape
    {
        public void getraidus()
        {
            Console.WriteLine("enter raidus");
            R = Convert.ToSingle(Console.ReadLine());
        }
    }
    class methodoverriding
    {
        public static void Main()
        {
            reactangle r = new reactangle();
            r.getlb();
            Console.WriteLine(r.area());
            circle c = new circle();
            c.getraidus();
            Console.WriteLine(c.area());
            Console.ReadLine();
        }
    }
}