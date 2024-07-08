using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpCity { get; set; }
        public double EmpSalary { get; set; }
    }
    class que3
    {
        public static void Empcalling()
        {
            List<employee> emplist = new List<employee>();
            Console.Write("Enter how many employee deatils you want to enter : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee details : ");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter employee {i+1} details :");
                employee emp = enterempdetails();
                emplist.Add(emp);
            }

            Console.WriteLine("All employees data:");
            DisplayAllEmployees(emplist);

            Console.WriteLine("\nEmployees with salary greater than 45000:");
            DisplayEmployeesWithHighSalary(emplist);

            Console.WriteLine("\nEmployees from Bangalore:");
            DisplayEmployeesFromCity(emplist, "Bangalore");

            Console.WriteLine("\nEmployees data sorted by names in ascending order:");
            DisplayEmployeesSortedByName(emplist);
        }

        static employee enterempdetails()
        {
            Console.Write($"Enter Employee ID :");
            int e_id = int.Parse(Console.ReadLine());
            Console.Write($"Enter Employee Name :");
            string e_name = Console.ReadLine();
            Console.Write($"Enter Employee City :");
            string e_city = Console.ReadLine();
            Console.Write($"Enter Employee Salary :");
            double e_sal = double.Parse(Console.ReadLine());
            return new employee
            {
                EmpId = e_id,
                EmpName = e_name,
                EmpCity = e_city,
                EmpSalary = e_sal
            };
        }

        static void DisplayAllEmployees(List<employee> emplist)
        {
            foreach (var employee in emplist)
            {
                Console.WriteLine($"Employee ID:{employee.EmpId} , Employee Name:{employee.EmpName} , Employee City:{employee.EmpCity} , Employee Salary:{employee.EmpSalary}");
            }
        }

        static void DisplayEmployeesWithHighSalary(List<employee> emplist)
        {
            var highSalaryEmployees = emplist.Where(e => e.EmpSalary > 45000);
            foreach (var employee in highSalaryEmployees)
            {
                Console.WriteLine($"Employee ID:{employee.EmpId} , Employee Name:{employee.EmpName} , Employee City:{employee.EmpCity} , Employee Salary:{employee.EmpSalary}");
            }
        }

        static void DisplayEmployeesFromCity(List<employee> emplist, string city)
        {
            var cityEmployees = emplist.Where(e => e.EmpCity.ToLower() == city.ToLower());
            foreach (var employee in cityEmployees)
            {
                Console.WriteLine($"Employee ID:{employee.EmpId} , Employee Name:{employee.EmpName} , Employee City:{employee.EmpCity} , Employee Salary:{employee.EmpSalary}");
            }
        }

        static void DisplayEmployeesSortedByName(List<employee> emplist)
        {
            var sortedEmployees = emplist.OrderBy(e => e.EmpName);
            foreach (var employee in sortedEmployees)
            {
                Console.WriteLine($"Employee ID:{employee.EmpId} , Employee Name:{employee.EmpName} , Employee City:{employee.EmpCity} , Employee Salary:{employee.EmpSalary}");
            }
        }
    }
}
