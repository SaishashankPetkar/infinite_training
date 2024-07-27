using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Linq_Assignment
{
    class que10
    {
        public static void que10calling()
        {
            //Display total number of employee based on city and title
            DataTable dataretrive = Employee.GetData();
            var que10 = dataretrive.AsEnumerable().GroupBy(row => new
            {
                City = row.Field<string>("City"),
                Title = row.Field<string>("Title")
            })
            .Select(row => new
             {
                  city = row.Key.City,
                  title = row.Key.Title,
                  totcount = row.Count()
             });
            if (que10 != null)
            {
                Console.WriteLine("Total number of employee based on city and title :-");
                foreach (var r in que10)
                {
                    Console.WriteLine($"Total Number of employees belonging to '{r.city}' with title '{r.title}' : {r.totcount}");
                }
            }
            else
            {
                Console.WriteLine("No records found");
            }
        }
    }
}
