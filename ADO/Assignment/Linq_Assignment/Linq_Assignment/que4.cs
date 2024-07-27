using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Linq_Assignment
{
    class que4
    {
        public static void que4calling()
        {
            //Display total number of employees
            DataTable dataretrive = Employee.GetData();
            var que4 = dataretrive.AsEnumerable().Count();
            Console.WriteLine("Total Number of employees : "+que4);
        }
    }
}
