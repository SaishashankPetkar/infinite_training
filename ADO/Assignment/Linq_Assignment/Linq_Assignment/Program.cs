using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Linq_Assignment
{
    public class Employee
    {
        public static DataTable GetData()
        {
            DataTable table = new DataTable();
            table.Columns.Add("EmployeeID", typeof(int));
            table.Columns.Add("FirstName", typeof(string));
            table.Columns.Add("LastName", typeof(string));
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("DOB", typeof(DateTime));
            table.Columns.Add("DOJ", typeof(DateTime));
            table.Columns.Add("City", typeof(string));

            table.Rows.Add(1001, "Malcolm", "Daruwalla", "Manager", new DateTime(1984, 11, 16), new DateTime(2011, 6, 8), "Mumbai");
            table.Rows.Add(1002, "Asdin", "Dhalla", "AsstManager", new DateTime(1984, 8, 20), new DateTime(2012, 7, 7), "Mumbai");
            table.Rows.Add(1003, "Madhavi", "Oza", "Consultant", new DateTime(1987, 11, 14), new DateTime(2015, 4, 12), "Pune");
            table.Rows.Add(1004, "Saba", "Shaikh", "SE", new DateTime(1990, 6, 3), new DateTime(2016, 2, 2), "Pune");
            table.Rows.Add(1005, "Nazia", "Shaikh", "SE", new DateTime(1991, 3, 8), new DateTime(2016, 2, 2), "Mumbai");
            table.Rows.Add(1006, "Amit", "Pathak", "Consultant", new DateTime(1989, 11, 7), new DateTime(2014, 8, 8), "Chennai");
            table.Rows.Add(1007, "Vijay", "Natrajan", "Consultant", new DateTime(1989, 12, 2), new DateTime(2015, 6, 1), "Mumbai");
            table.Rows.Add(1008, "Rahul", "Dubey", "Associate", new DateTime(1993, 11, 11), new DateTime(2014, 11, 6), "Chennai");
            table.Rows.Add(1009, "Suresh", "Mistry", "Associate", new DateTime(1992, 8, 12), new DateTime(2014, 12, 3), "Chennai");
            table.Rows.Add(1010, "Sumit", "Shah", "Manager", new DateTime(1991, 4, 12), new DateTime(2016, 1, 2), "Pune");

            return table;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //que1.que1calling();
            //que2.que2calling();
            //que3.que3calling();
            //que4.que4calling();
            //que5.que5calling();
            //que6.que6calling();
            //que7.que7calling();
            //que8.que8calling();
            //que9.que9calling();
            //que10.que10calling();
            que11.que11calling();
            Console.Read();
        }
    }
}
