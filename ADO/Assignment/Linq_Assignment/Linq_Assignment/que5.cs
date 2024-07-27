using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Linq_Assignment
{
    class que5
    {
        public static void que5calling()
        {
            //Display total number of employees belonging to “Chennai”
            DataTable dataretrive = Employee.GetData();
            var que5 = dataretrive.AsEnumerable().Where(row => row.Field<string>("City") == "Chennai").Count();
            Console.WriteLine("Total Number of employees belonging to 'Chennai': " + que5);
        }
    }
}
