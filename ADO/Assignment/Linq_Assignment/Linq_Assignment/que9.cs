using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Linq_Assignment
{
    class que9
    {
        public static void que9calling()
        {
            //Display total number of employee based on City
            DataTable dataretrive = Employee.GetData();
            var que9 = dataretrive.AsEnumerable().GroupBy(row => row.Field<string>("City"))
                .Select(row => new
                {
                    city = row.Key,
                    totcount = row.Count()
                });
            if (que9 != null)
            {
                Console.WriteLine("Total number of employee based on City :-");
                foreach (var r in que9)
                {
                    Console.WriteLine($"Total Number of employees belonging to '{r.city}' : {r.totcount}");
                }
            }
            else
            {
                Console.WriteLine("No records found");
            }
        }
    }
}
