using System;


namespace Day1_Dotnet_project
{
    class myclass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C sharp classes.");
            Console.WriteLine("Please Enter Your FirstName");
            string fname = Console.ReadLine();
            Console.WriteLine("Please Enter Your LastName");
            string lname = Console.ReadLine();
            Console.WriteLine("Your First Name is " + fname + " and LastName is "+ lname);//concatenation
            Console.WriteLine("Your Name is {0} and Last Name is {1}", fname,lname);//placeholder substitution
            Console.WriteLine($"Your First Name is {fname} and Last Name is {lname}");//string interpolation
            //to call a non-static function
            //we need to have an object
            myclass calss = new myclass();
            calss.Display("Sai");
            //to call a static function of class,we dont need an object
            int sum = Addnos(5, 6);
            Console.WriteLine("The sum is:" + sum);
            Console.Read();
            /*Program to understand input and output functionalityes in a console based application*/
        }
        void Display(string username) //function signature
        {
            Console.WriteLine("Welcome " + username); //funtion defination/body
        }

        static int Addnos(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
