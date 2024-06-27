using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Doctor
    {
        public int RegnNo { get; set; } 
        public string Name { get; set; } 
        public double Feescharged { get; set; }

        public Doctor(int r_no, string d_name, double d_fees)
        {
            RegnNo = r_no;
            Name = d_name;
            Feescharged = d_fees;
        }

        public void displaydoc()
        {
            Console.WriteLine();
            Console.WriteLine("Hello Doctor, your details are as follows : ");
            Console.WriteLine("Registration Number : "+RegnNo);
            Console.WriteLine("Name : "+Name);
            Console.WriteLine("Fees charged : "+Feescharged);

        }
    }
    class que5
    {
        public static void doccalling()
        {
            Console.WriteLine("Hello Doctor !");
            Console.Write("Please enter your name : ");
            string d_name = Console.ReadLine();
            Console.Write("Please enter your Registration number : ");
            int d_rno = int.Parse(Console.ReadLine());
            Console.Write("Please enter the fees charged : ");
            double d_fees = Convert.ToDouble(Console.ReadLine());

            Doctor doc = new Doctor(d_rno, d_name, d_fees);
            doc.displaydoc();
        }
    }
}
