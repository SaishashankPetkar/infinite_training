using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Linq_Assignment
{
    class que1
    {
        public static void que1calling()
        {
            //Display a list of all the employee who have joined before 1/1/2015
            DataTable dataretrive = Employee.GetData();
            var que1 = dataretrive.AsEnumerable().Where(row => row.Field<DateTime>("DOJ") < new DateTime(2015, 1, 1))
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
            if (que1 != null)
            {
                Console.WriteLine("List of all the employee who have joined before 1/1/2015 :");
                foreach (var r in que1)
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
                Console.WriteLine("No Matching records found for condition all the employee who have joined before 1/1/2015");
            }
        }
    }
}
