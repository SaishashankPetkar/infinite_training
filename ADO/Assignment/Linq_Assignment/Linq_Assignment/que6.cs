using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Linq_Assignment
{
    class que6
    {
        public static void que6calling()
        {
            //Display highest employee id from the list
            DataTable dataretrive = Employee.GetData();
            var que6 = dataretrive.AsEnumerable().Max(row => row.Field<int>("EmployeeID"));
            Console.WriteLine("Highest employee id from the list of employees: " + que6);
        }
    }
}
