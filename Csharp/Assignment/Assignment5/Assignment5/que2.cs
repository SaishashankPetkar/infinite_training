using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Box
    {
        float Length, Breadth;
        public Box(float len,float breth)
        {
            if (len < 0 || breth <0)
            {
                throw new ArgumentException("Lenghth and breadth cannot be negative");
            }
            else
            {
                Length = len;
                Breadth = breth;
            }
        }

        public static Box Add(Box box1,Box box2)
        {
            float newlengh = box1.Length + box2.Length;
            float newbreadth = box1.Breadth + box2.Breadth;
            return new Box(newlengh, newbreadth);
        }

        public void display()
        {
            Console.WriteLine($"Length : {Length} & Breadth : {Breadth}");
        }
    }
    class test
    {
        public static void boxcalling()
        {
            try
            {
                Console.WriteLine("Enter Details of Box 1");
                Console.Write("Enter length of box 1 : ");
                float box1len = float.Parse(Console.ReadLine());
                Console.Write("Enter breadth of box 1 : ");
                float box1breth = float.Parse(Console.ReadLine());
                Box box1 = new Box(box1len, box1breth);
                Console.WriteLine();
                Console.WriteLine("The length and breadth of box 1 is :");
                box1.display();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Enter Details of Box 2");
                Console.Write("Enter length of box 2 : ");
                float box2len = float.Parse(Console.ReadLine());
                Console.Write("Enter breadth of box 2 : ");
                float box2breth = float.Parse(Console.ReadLine());
                Box box2 = new Box(box2len, box2breth);
                Console.WriteLine();
                Console.WriteLine("The length and breadth of box 2 is :");
                box2.display();
                Console.WriteLine();
                Console.WriteLine();
                Box box3 = Box.Add(box1, box2);
                Console.WriteLine("The length and breadth of box 3 after adding box 1 and box 2 is :");
                Console.WriteLine();
                box3.display();
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine("Error : "+ex.Message);
            }
        }
    }
    class que2
    {
        public static void testcalling()
        {
            test.boxcalling();
        }
    }
}
