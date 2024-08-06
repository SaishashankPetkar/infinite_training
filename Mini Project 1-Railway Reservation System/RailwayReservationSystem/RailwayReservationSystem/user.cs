using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RailwayReservationSystem
{
    class user
    {
        public static SqlConnection con = null;
        public static SqlDataAdapter da;
        static void Main()
        {
            con = new SqlConnection("data source = ICS-LT-B7S0LQ3\\SQLEXPRESS; initial catalog = RailwayReservationSystemDB; " +
                "user id=SA;password=India@123");
            con.Open();
            da = new SqlDataAdapter("select * from test", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "test_r");
            DataTable dt = ds.Tables["test_r"];
            foreach (DataRow drow in dt.Rows)
            {
                foreach (DataColumn dcol in dt.Columns)
                {
                    Console.Write(drow[dcol]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
 }
