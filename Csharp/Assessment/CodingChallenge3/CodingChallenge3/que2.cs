using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge3
{
    class Box
    {
        public int Length, Breadth;

        public static Box Add(Box b1,Box b2)
        {
            Box res = new Box();
            res.Length = b1.Length + b2.Length;
            res.Breadth = b1.Breadth + b2.Breadth;
            return res;
        }

    }

    class test
    {
        public static void boxcall()
        {
            Box box1 = new Box();
            Console.WriteLine("Enter Details for Box Object 1");
            Console.Write("Enter length of box object 1 : ");
            box1.Length = int.Parse(Console.ReadLine());
            Console.Write("Enter breadth of box object 1 : ");
            box1.Breadth = int.Parse(Console.ReadLine());
            Console.WriteLine($"The details of Box Object 1 Length: {box1.Length} & breadth: {box1.Breadth}");
            Box box2 = new Box();
            Console.WriteLine("Enter Details for Box Object 2");
            Console.Write("Enter length of box object 2 : ");
            box2.Length = int.Parse(Console.ReadLine());
            Console.Write("Enter breadth of box object 2 : ");
            box2.Breadth = int.Parse(Console.ReadLine());
            Console.WriteLine($"The details of Box Object 1 Length: {box2.Length} & breadth: {box2.Breadth}");
            Box box3 = Box.Add(box1, box2);
            Console.WriteLine("The length and breadth of box object 3 after adding box object 1 and box object 2 is :");

            Console.WriteLine($"Length: {box3.Length} & breadth: {box3.Breadth}");
        }
    }
    class que2
    {
        public static void testcall()
        {
            test.boxcall();
        }
    }
}
