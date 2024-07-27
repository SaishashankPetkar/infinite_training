using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Linq_Assignment
{
    class que8
    {
        public static void que8calling()
        {
            //Display total number of employee whose designation is not “Associate”
            DataTable dataretrive = Employee.GetData();
            var que8 = dataretrive.AsEnumerable().Count(row => row.Field<string>("Title") != "Associate");
            Console.WriteLine("total number of employee whose designation is not 'Associate' : "+que8);
        }
    }
}
