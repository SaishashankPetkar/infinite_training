using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Linq_Assignment
{
    class que11
    {
        public static void que11calling()
        {
            //Display total number of employee who is youngest in the list
            DataTable dataretrive = Employee.GetData();
            var eyoungest = dataretrive.AsEnumerable().Min(row => row.Field<DateTime>("DOB"));
            var eyoungestcount = dataretrive.AsEnumerable().Count(row => row.Field<DateTime>("DOB") == eyoungest);
            Console.WriteLine($"Total number of employee who is youngest : {eyoungestcount}");
            Console.WriteLine();
            var que11=dataretrive.AsEnumerable().Where(row => row.Field<DateTime>("DOB") == eyoungest)
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
            if (que11 != null)
            {
                Console.WriteLine("Details of employee who is youngest in the list :");
                foreach (var r in que11)
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
                Console.WriteLine("No Matching records found");
            }

        }
    }
}
