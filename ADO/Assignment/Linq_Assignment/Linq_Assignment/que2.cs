using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Linq_Assignment
{
    class que2
    {
        public static void que2calling()
        {
            //Display a list of all the employee whose date of birth is after 1 / 1 / 1990
            DataTable dataretrive = Employee.GetData();
            var que2 = dataretrive.AsEnumerable().Where(row => row.Field<DateTime>("DOB") > new DateTime(1990, 1, 1))
                .Select(row => new
                {
                    EmployeeID = row.Field<int>("EmployeeID"),
                    FirstName = row.Field<string>("FirstName"),
                    LastName = row.Field<string>("LastName"),
                    Title = row.Field<string>("Title"),
                    DOB = row.Field<DateTime>("DOB"),
                    DOJ = row.Field<DateTime>("DOJ"),
                    City = row.Field<string>("City")
                });
            if (que2 != null)
            {
                Console.WriteLine("List of all the employee whose date of birth is after 1 / 1 / 1990 :");
                foreach (var r in que2)
                {
                    Console.WriteLine($"EmployeeID: {r.EmployeeID}, " +
                        $"FirstName: {r.FirstName}, " +
                        $"LastName: {r.LastName}, " +
                        $"Title: {r.Title}, " +
                        $"DOB: {r.DOB:yyyy-MM-dd}, " +
                        $"DOJ: {r.DOJ:yyyy-MM-dd}," +
                        $"City: {r.City}");
                }
            }
            else
            {
                Console.WriteLine("No Matching records found for condition all the employee whose date of birth is after 1 / 1 / 1990");
            }
        }
    }
}
