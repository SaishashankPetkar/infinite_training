using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class accounts
    {
        int accno, amt, bal;
        string custname, acctype, transtype;
        public accounts(int ano,string cname,string actype,int balance)
        {
            accno = ano;
            custname = cname;
            acctype = actype;
            bal = balance;
        }

        public void updatebalnce(string trant,int a)
        {
            transtype = trant;
            amt = a;
            if (transtype.ToLower() == "d")
            {
                Credit(amt);
            }
            else if (transtype.ToLower() == "w")
            {
                Debit(amt);
            }
            else
            {
                Console.WriteLine("Invalid transaction type.");
            }
        }
        void Credit(int a)
        {
            bal = bal + a;
            Console.WriteLine($"{a} deposited successfully.");
        }
        void Debit(int a)
        {
            if (a <= bal)
            {
                bal = bal - a;
                Console.WriteLine($"{a} withdrawn successfully.");
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }
        public void showdata()
        {
            Console.WriteLine($"Account No: {accno}");
            Console.WriteLine($"Customer Name: {custname}");
            Console.WriteLine($"Account Type: {acctype}");
            Console.WriteLine($"Balance: {bal}");
        }

    }
    public class que1
    {
        public static void accalling()
        {
            Console.Write("Enter Your Account Number : ");
            int account_num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Your Name : ");
            string customer_name = Console.ReadLine();
            Console.Write("Enter Your Account Type (Savings/Current) : ");
            string account_type = Console.ReadLine();
            int balance = 0;
            accounts ac = new accounts(account_num, customer_name, account_type, balance);
            ac.showdata();
            while(true)
            {
                Console.Write("Do you want to perform any transaction : ");
                string ans = Console.ReadLine();
                if (ans.ToLower() == "yes")
                {
                    Console.Write("Which transaction You want to perform ? type d:Deposit and w:Withdraw : ");
                    string ttype = Console.ReadLine();
                    if(ttype.ToLower() == "d")
                    {
                        Console.Write("Enter the amount that you want to deposit : ");
                        int amount = int.Parse(Console.ReadLine());
                        ac.updatebalnce(ttype, amount);
                        ac.showdata();
                    }
                    else if (ttype.ToLower() == "w")
                    {
                        Console.Write("Enter the amount that you want to withdraw : ");
                        int amount = int.Parse(Console.ReadLine());
                        ac.updatebalnce(ttype, amount);
                        ac.showdata();
                    }
                }
                else
                {
                    break;
                }
            }
            Console.Read();

        }
    }
}
