using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4_dotnet
{
    class Distance
    {
        public int dist1;
        //public Distance(int d)
        //{
        //    dist1 = d;
        //}

        //operator overloading function '+'
        public static Distance operator +(Distance d1,Distance d2)
        {
            Distance temp = new Distance();
            temp.dist1 = d1.dist1 + d2.dist1;
            return temp;

        }

        //operator overloading function '++'
        public static Distance operator ++(Distance inc)
        {
            Distance ince = new Distance();
            ince.dist1 = inc.dist1 + 1;
            return ince;
            //inc.dist1++;
            //return inc;
        }
    }
    class operateroverloding
    {
        static void Main()
        {
            Distance d1 = new Distance();
            Distance d2 = new Distance();
            d1.dist1 = 50;
            d2.dist1 = 80;
            Distance totdist = d1 + d2;
            Console.WriteLine("The total distance is {0}", totdist.dist1);

            Distance incdist = d1++;
            //d1++;
            Console.WriteLine("The incremented distance is {0}", incdist.dist1);
            Console.Read();
        }
    }
}
