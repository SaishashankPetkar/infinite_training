using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class saledetails
    {
        int salesno, productno, qty;
        double price, totalamount;
        DateTime dateofsale;

        public saledetails(int salesno, int productno, double price, int qty, DateTime dateofsale)
        {
            this.salesno = salesno;
            this.productno = productno;
            this.price = price;
            this.qty = qty;
            this.dateofsale = dateofsale;
            this.totalamount = this.qty * this.price;
        }

        public void showdata()
        {
            Console.WriteLine($"Sales No: {this.salesno}");
            Console.WriteLine($"Product No: {this.productno}");
            Console.WriteLine($"Price: {this.price}");
            Console.WriteLine($"Quantity: {this.qty}");
            Console.WriteLine($"Date of Sale: {this.dateofsale.ToShortDateString()}");
            Console.WriteLine($"Total Amount: {this.totalamount}");
        }
    }
    public class que3
    {
        public static void sales()
        {
            Console.Write("Enter the sales number of product : ");
            int s_no = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the product number of the product : ");
            int p_no = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the price of the product : ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the date of sales : ");
            DateTime s_date = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Enter the quantity of produts sold : ");
            int qty = Convert.ToInt32(Console.ReadLine());

            saledetails sales_d = new saledetails(s_no,p_no,price,qty,s_date);
            Console.WriteLine();
            sales_d.showdata();
            Console.Read();
        }
    }
}
