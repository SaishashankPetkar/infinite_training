using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class students
    {
        int rollno;
        string name, Class, Semester, branch;
        int[] marks = new int[5];

        public students(int rno,string sname,string cls,string SEM,string brnch)
        {
            rollno = rno;
            name = sname;
            Class = cls;
            Semester = SEM;
            branch = brnch;
        }

        public void getmarks()
        {
            Console.WriteLine("Enter marks of 5 subjects ");
            for(int i = 0; i < 5; i++)
            {
                Console.Write($"Enter marks of subject {i+1} : ");
                marks[i] = int.Parse(Console.ReadLine());
            }
        }

        public void DisplayResult()
        {
            int totmarks = 0;
            bool failed = false;

            foreach (int mark in marks)
            {
                totmarks =totmarks + mark;
                if (mark < 35)
                {
                    failed = true;
                }
            }

            double avgmarks = totmarks / marks.Length;

            Console.WriteLine($"Your average marks are : {avgmarks}");

            if (failed || avgmarks < 50)
            {
                Console.WriteLine("Your result is: Failed");
            }
            else
            {
                Console.WriteLine("Your result is: Passed");
            }
        }

        public void DisplayData()
        {
            Console.WriteLine($"Roll No: {rollno}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Class: {Class}");
            Console.WriteLine($"Semester: {Semester}");
            Console.WriteLine($"Branch: {branch}");
            Console.WriteLine("Marks: ");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine($"Subject {i + 1} mark are : {marks[i]}");
            }
        }
    }

    public class que2
    {
        public static void stud()
        {
            Console.Write("Enter Your Roll Number : ");
            int r_no = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Your Name : ");
            string s_name = Console.ReadLine();
            Console.Write("Enter Your Class (years of study) : ");
            string yr = Console.ReadLine();
            Console.Write("Enter Your Semester : ");
            string sem = Console.ReadLine();
            Console.Write("Enter Your Branch : ");
            string brnch = Console.ReadLine();

            students stud = new students(r_no, s_name, yr, sem, brnch);

            stud.getmarks();
            Console.WriteLine();
            stud.DisplayData();
            stud.DisplayResult();
            Console.Read();
        }
    }
}
