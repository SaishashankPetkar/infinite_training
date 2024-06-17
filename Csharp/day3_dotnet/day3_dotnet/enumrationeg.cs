using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_dotnet
{
    enum cities { Agra=3, Benglore=1, Chennai=2, Delhi=5, Hydrabad=4, Kolkata=7, Mumbai=6};
    class enumrationeg
    {
        enum days { Mon, Tue, Wed, Thur, Fri, Sat, Sun };

        public static void enumops()
        {
            foreach(int x in Enum.GetValues(typeof(cities)))
            {
                if (x == 1)
                    Console.WriteLine(Enum.GetName(typeof(cities),x) + "Is a garden city");
                else if(x==2)
                    Console.WriteLine(Enum.GetName(typeof(cities), x) + "Is a garden city");
                else if(x==6)
                    Console.WriteLine(Enum.GetName(typeof(cities), x) + "Is a garden city");
            }
            foreach(var v in Enum.GetNames(typeof(cities)))
            {
                Console.WriteLine(v);
            }
        }
    }
}
