using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Linq_Assignment
{
    class que7
    {
        public static void que7calling()
        {
            //Display total number of employee who have joined after 1 / 1 / 2015
            DataTable dataretrive = Employee.GetData();
            var que7 = dataretrive.AsEnumerable().Count(row => row.Field<DateTime>("DOJ") > new DateTime(2015, 1, 1));
            Console.WriteLine("Total number of employee who have joined after 1 / 1 / 2015: " + que7);
        }
    }
}
