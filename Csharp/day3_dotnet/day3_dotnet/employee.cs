using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_dotnet
{
    class employee
    {
        //fields
        int empid;
        string empname;
        DateTime doj;
        float salary;

        //1.constructor
        public employee()
        {
            empid = 10;
            empname = "infinte";
            doj = Convert.ToDateTime("02/02/2024");
            salary = 50000;
        }

        //2.constructor with parametrs (parameterized constructor)
        public employee(int eid,string name,float sal)
        {
            empid = eid;
            empname = name;
            salary = sal;
        }

        //3.constructor with this key word
        public employee(int empid,string empname)
        {
            this.empid = empid;
            this.empname = empname;
        }

        //methods/functions

        public void getempdetails()
        {
            Console.WriteLine("Enter emp_id,name,doj and salary");
            empid = Convert.ToInt32(Console.ReadLine());
            empname = Console.ReadLine();
            doj = Convert.ToDateTime(Console.ReadLine());
            salary = Convert.ToSingle(Console.ReadLine());

        }

        public void showempdetails()
        {
            Console.WriteLine($"Employee id {empid},Employee Name {empname}, Date Of Joining {doj} and Salary {salary}");

        }

        //destructor
        ~employee()
        {
            Console.WriteLine("Bye employee");

        }
    }
    class employeetest
    {
        public static void Main()
        {
            employee emp = new employee();//empty constructor
            //emp.getempdetails();
            emp.showempdetails();
            employee emp1 = new employee(20,"shashank",25000); //invoking with parametrs
            Console.WriteLine("-----------------------------");
            //emp1.getempdetails();
            emp1.showempdetails();
            Console.WriteLine("-----------------------------");
            employee emp2 = new employee(20, "Johan");
            emp2.showempdetails();
            Console.Read();
        }
    }
}
