using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge4
{
    public delegate int CalculatorOps(int a, int b);
    class que2
    {
        public static void Delegatecallingfunction()
        {
            Console.WriteLine("Delegat Operations !");
            Console.WriteLine();
            Console.Write("Enter Number 1 to Perform Addition, Subtraction and Multiplication Operations : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Number 2 to Perform Addition, Subtraction and Multiplication Operations : ");
            int num2 = int.Parse(Console.ReadLine());

            CalculatorOps add = new CalculatorOps(Add);
            CalculatorOps substract = new CalculatorOps(Substract);
            CalculatorOps multiply = new CalculatorOps(Multiply);
            Console.WriteLine();
            Console.WriteLine($"The addition of {num1} and {num2} is : {add(num1,num2)}");
            Console.WriteLine($"The subtraction of {num1} and {num2} is : {substract(num1, num2)}");
            Console.WriteLine($"The multiplication of {num1} and {num2} is : {multiply(num1, num2)}");
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Substract(int a, int b)
        {
            return a - b;
        }
        static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
