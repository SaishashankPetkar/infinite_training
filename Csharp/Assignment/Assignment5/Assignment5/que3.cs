using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Employee
    {
        int Empid;
        string Empname;
        float Salary;
        public Employee(int e_id, string e_name, float sal)
        {
            Empid = e_id;
            Empname = e_name;
            Salary = sal;
        }
        public void Display()
        {
            Console.Write($"Employee ID: {Empid}, Employee Name: {Empname}, Salary: {Salary}, ");
        }
    }
    public class ParttimeEmployee : Employee
    {
        float Wages;
        public ParttimeEmployee(int empid, string empname, float salary, float wage) : base(empid, empname, salary)
        {
            Wages = wage;
        }
        public new void Display()
        {
            base.Display();
            Console.Write($"Wages: {Wages}");
        }
    }

    class que3
    {
        public static void que3ptempcalling()
        {
            Console.WriteLine("Enter Employee Details : ");
            Console.Write("Enter Employee ID : ");
            int Id = int.Parse(Console.ReadLine());
            Console.Write("Enter Employee Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter Employee Salary : ");
            float sal = float.Parse(Console.ReadLine());
            Console.Write("Enter Employee Wage : ");
            float wage = float.Parse(Console.ReadLine());
            ParttimeEmployee ptEmployee = new ParttimeEmployee(Id, name, sal, wage);
            Console.WriteLine();
            ptEmployee.Display();
        }
    }
}

