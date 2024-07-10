using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge4
{
    public class employee
    {
        public int empid { get; set; }
        public string emp_firstname { get; set; }
        public string emp_lastname { get; set; }
        public string emp_title { get; set; }
        public DateTime emp_Dob { get; set; }
        public DateTime emp_Doj { get; set; }
        public string emp_city { get; set; }

        public employee(int id, string firstName, string lastName, string title, DateTime dob, DateTime doj, string city)
        {
            empid = id;
            emp_firstname = firstName;
            emp_lastname = lastName;
            emp_title = title;
            emp_Dob = dob;
            emp_Doj = doj;
            emp_city = city;
        }

    }
    class que3
    {
        public static void employeedetailscalling()
        {
            List<employee> emplist = new List<employee>();
            emplist.Add(new employee(1001, "Malcolm", "Daruwalla", "Manager", new DateTime(1984, 11, 16), new DateTime(2011, 06, 08), "Mumbai"));
            emplist.Add(new employee(1002,"Asdin", "Dhalla", "AsstManager", new DateTime(1984, 08, 20), new DateTime(2012, 07,07), "Mumbai"));
            emplist.Add(new employee(1003, "Madhavi", "Oza", "Consultant", new DateTime(1987, 11, 14), new DateTime(2015, 04, 12), "Pune"));
            emplist.Add(new employee(1004, "Saba", "Shaikh", "SE", new DateTime(1990, 06, 03), new DateTime(2016, 02, 02), "Pune"));
            emplist.Add(new employee(1005, "Nazia", "Shaikh", "SE", new DateTime(1991, 03, 08), new DateTime(2016, 02, 02), "Mumbai"));
            emplist.Add(new employee(1006, "Amit", "Pathak", "Consultant", new DateTime(1989, 11, 07), new DateTime(2014, 08, 08), "Chennai"));
            emplist.Add(new employee(1007, "Vijay", "Natrajan", "Consultant", new DateTime(1989, 12, 02), new DateTime(2015, 06, 01), "Mumbai"));
            emplist.Add(new employee(1008, "Rahul", "Dubey", "Associate", new DateTime(1993, 11, 11), new DateTime(2014, 11, 06), "Chennai"));
            emplist.Add(new employee(1009, "Suresh", "Mistry", "Associate", new DateTime(1992, 08, 11), new DateTime(2014, 12, 03), "Chennai"));
            emplist.Add(new employee(1010, "Sumit", "Shah", "Manager", new DateTime(1991, 04, 12), new DateTime(2016, 01, 02), "Pune"));

            Console.WriteLine("All employees data:");
            DisplayAllEmployees(emplist);
            Console.WriteLine();
            Console.WriteLine("Employees not in Mumbai:");
            displaymumbai(emplist,"Mumbai");
            Console.WriteLine();
            Console.WriteLine("Employees with title 'AsstManager':");
            displayempasstmangr(emplist, "AsstManager");
            Console.WriteLine();
            Console.WriteLine("Employees whose last name starts with 'S':");
            displaywithlastnames(emplist);
        }

        static void DisplayAllEmployees(List<employee> emplist)
        {
            foreach (var employee in emplist)
            {
                Console.WriteLine($"Employee ID:{employee.empid} , Employee First Name:{employee.emp_firstname},Employee Last Name:{employee.emp_lastname},Employee Title:{employee.emp_title},Employee DOB:{employee.emp_Dob.ToShortDateString()},Employee DOJ:{employee.emp_Doj.ToShortDateString()} , Employee City:{employee.emp_city}");
            }
        }

        static void displaymumbai(List<employee> emplist,string city)
        {
            var nonMumbaiEmployees = emplist.Where(e => e.emp_city != city);
            foreach (var employee in nonMumbaiEmployees)
            {
                Console.WriteLine($"Employee ID:{employee.empid} , Employee First Name:{employee.emp_firstname},Employee Last Name:{employee.emp_lastname},Employee Title:{employee.emp_title},Employee DOB:{employee.emp_Dob.ToShortDateString()},Employee DOJ:{employee.emp_Doj.ToShortDateString()} , Employee City:{employee.emp_city}");
            }
        }
        static void displayempasstmangr(List<employee> emplist, string title)
        {
            var asstmngrEmployees = emplist.Where(e => e.emp_title == title);
            foreach (var employee in asstmngrEmployees)
            {
                Console.WriteLine($"Employee ID:{employee.empid} , Employee First Name:{employee.emp_firstname},Employee Last Name:{employee.emp_lastname},Employee Title:{employee.emp_title},Employee DOB:{employee.emp_Dob.ToShortDateString()},Employee DOJ:{employee.emp_Doj.ToShortDateString()} , Employee City:{employee.emp_city}");
            }
        }

        static void displaywithlastnames(List<employee> emplist)
        {
            var lstratsEmployees = emplist.Where(e => e.emp_lastname.StartsWith("S"));
            foreach (var employee in lstratsEmployees)
            {
                Console.WriteLine($"Employee ID:{employee.empid} , Employee First Name:{employee.emp_firstname},Employee Last Name:{employee.emp_lastname},Employee Title:{employee.emp_title},Employee DOB:{employee.emp_Dob.ToShortDateString()},Employee DOJ:{employee.emp_Doj.ToShortDateString()} , Employee City:{employee.emp_city}");
            }
        }

    }
}
