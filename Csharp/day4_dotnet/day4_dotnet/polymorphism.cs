using System;

namespace day4_dotnet
{
    class polymorphism
    {
        public int add(int x,int y)
        {
            return x + y;
        }
        public float add(int a,int b,int c)
        {
            return a + b + c;
        }

        public static void swap(int num1,int num2)
        {
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
            Console.WriteLine($"Swapping of integer 1 {num1} and interger 2 {num2}");
        }

        public static void swap(char c1,char c2)
        {
            char temp = ' ';
            temp = c1;
            c1 = c2;
            c2 = temp;
            Console.WriteLine($"Swapping of charcater 1 {c1} and characater 2 {c2}");
        }

        public static void Main()
        {
            polymorphism poly = new polymorphism();
            Console.WriteLine(poly.add(5, 5));
            Console.WriteLine(poly.add(5, 10, 9));
            swap(1, 2);
            swap('a', 'n');
            Console.Read();
        }
    }
}
