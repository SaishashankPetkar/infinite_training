using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Customer
    {
        int customerid,age;
        string name,phone,city;

        //without arrguments
        public Customer()
        {
            customerid = 567;
            name = "Shashank";
            age = 23;
            phone = "9896996271";
            city = "Nashik";
        }

        //with arrguments
        public Customer(int c_id, string c_name, int c_age, string c_phone, string c_city)
        {
            customerid = c_id;
            name = c_name;
            age = c_age;
            phone = c_phone;
            city = c_city;
        }

        public static void displaycustomer(Customer customer)
        {
            Console.WriteLine($"Customer ID: {customer.customerid}");
            Console.WriteLine($"Name: {customer.name}");
            Console.WriteLine($"Age: {customer.age}");
            Console.WriteLine($"Phone: {customer.phone}");
            Console.WriteLine($"City: {customer.city}");
        }

        ~Customer()
        {
            Console.WriteLine("Destructor.");
        }
    }
    class que4
    {
        public static void customerdetails()
        {
            Console.WriteLine("Constructor with no arguments.");
            Customer customer1 = new Customer();
            Customer.displaycustomer(customer1);
            Console.WriteLine();
            Console.Write("Enter Customer Id : ");
            int c_id = int.Parse(Console.ReadLine());
            Console.Write("Enter Customer Name : ");
            string c_name = Console.ReadLine();
            Console.Write("Enter Customer Age : ");
            int c_age = int.Parse(Console.ReadLine());
            Console.Write("Enter Customer Phone Number : ");
            string c_phone = Console.ReadLine();
            Console.Write("Enter Customer City : ");
            string c_city = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Constructor with arguments.");
            Customer customer2 = new Customer(c_id, c_name, c_age, c_phone, c_city);
            Customer.displaycustomer(customer2);
            Console.Read();
        }
    }
}
