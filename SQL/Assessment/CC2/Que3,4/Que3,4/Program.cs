using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Que3_4
{
    class Program
    {
        public static SqlConnection connection = null;
        public static SqlDataAdapter da;
        static void Main(string[] args)
        {
            Procedurestoaddvalues();
            DisplayEmployeedata();
            Console.Read();
        }

        public static void Procedurestoaddvalues()
        {
            string empname = "Max";
            decimal empsal = 40000;
            char emptype = 'P';

            connection = new SqlConnection("data source = ICS-LT-B7S0LQ3\\SQLEXPRESS; initial catalog = Employeemanagement; " +
                "user id=SA;password=India@123");
            connection.Open();
            da = new SqlDataAdapter("AddrowstoEmpDetailstbl", connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@empname", empname);
            da.SelectCommand.Parameters.AddWithValue("@empsal", empsal);
            da.SelectCommand.Parameters.AddWithValue("@emptype", emptype);

            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                foreach (DataColumn dc in dt.Columns)
                {
                    Console.Write("New Genetated Employee Number is: "+dr[dc]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public static void DisplayEmployeedata()
        {
            connection = new SqlConnection("data source = ICS-LT-B7S0LQ3\\SQLEXPRESS; initial catalog = Employeemanagement; " +
                "user id=SA;password=India@123");
            connection.Open();
            da = new SqlDataAdapter("select * from Employee_Details", connection);
            DataSet ds = new DataSet();

            da.Fill(ds, "EmployeeDetails");
            DataTable dt = ds.Tables["EmployeeDetails"];

            Console.WriteLine("The EmployeeDetails Table Is As Follows : ");
            foreach (DataRow dr in dt.Rows)
            {
                foreach (DataColumn dc in dt.Columns)
                {
                    Console.Write(dr[dc]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
