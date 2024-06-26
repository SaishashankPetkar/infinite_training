using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge2
{
    abstract class students
    {
        public String name;
        public string stud_id;
        public double grade;

        public abstract bool IsPassed(double grade);
    }
    class Undergraduate : students
    {
        public Undergraduate(string s_name,string s_id,double s_grade)
        {
            name = s_name;
            stud_id = s_id;
            grade = s_grade;

        }

        public override bool IsPassed(double grade)
        {
            return grade > 70;
        }
    }
    class Graduate : students
    {
        public Graduate(string s_name, string s_id, double s_grade)
        {
            name = s_name;
            stud_id = s_id;
            grade = s_grade;

        }

        public override bool IsPassed(double grade)
        {
            return grade > 80;
        }
    }
    class que1
    {
        public static void studentcall()
        {
            Console.Write("Are you a Undergraduate or Graduate Student (Enter Undergraduate or Graduate) : ");
            string ans = Console.ReadLine();
            if (ans.ToLower() == "undergraduate")
            {
                Console.WriteLine("Undergraduate Result Check !");
                Console.Write("Please enter Your Name : ");
                string stud_name = Console.ReadLine();
                Console.Write("Please enter Your Student ID : ");
                string stud_id = Console.ReadLine();
                Console.Write("Please enter Your Grade (Enter Your percentage) : ");
                double stud_grade = Convert.ToDouble(Console.ReadLine());
                Undergraduate ug = new Undergraduate(stud_name, stud_id, stud_grade);
                if(ug.IsPassed(stud_grade) == true)
                {
                    Console.WriteLine($"Student Name : {stud_name} , Student ID : {stud_id} ");
                    Console.WriteLine($"You are PASS .As your grade is {stud_grade}");
                }
                else
                {
                    Console.WriteLine($"Student Name : {stud_name} , Student ID : {stud_id} ");
                    Console.WriteLine($"You are FAIL .As your grade is {stud_grade}");
                }
            }
            else if(ans.ToLower() == "graduate")
            {
                Console.WriteLine("Graduate Result Check !");
                Console.Write("Please enter Your Name : ");
                string stud_name = Console.ReadLine();
                Console.Write("Please enter Your Student ID : ");
                string stud_id = Console.ReadLine();
                Console.Write("Please enter Your Grade (Enter Your percentage) : ");
                double stud_grade = Convert.ToDouble(Console.ReadLine());
                Graduate grd = new Graduate(stud_name, stud_id, stud_grade);
                if (grd.IsPassed(stud_grade) == true)
                {
                    Console.WriteLine($"Student Name : {stud_name} , Student ID : {stud_id} ");
                    Console.WriteLine($"You are PASS .As your grade is {stud_grade}");
                }
                else
                {
                    Console.WriteLine($"Student Name : {stud_name} , Student ID : {stud_id} ");
                    Console.WriteLine($"You are FAIL .As your grade is {stud_grade}");
                }
            }
            else
            {
                Console.WriteLine("Plesase enter a vaild Input . ");
            }
        
        }
    }
}
