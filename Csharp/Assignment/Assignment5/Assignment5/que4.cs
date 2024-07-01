using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public interface IStudent
    {
        int StudentId { get; set; }
        string Name { get; set; }
        void ShowDetails();
    }

    public class Dayscholar : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public Dayscholar(int stud_id, string s_name)
        {
            StudentId = stud_id;
            Name = s_name;
        }

        // Method to display the day scholar's details
        public void ShowDetails()
        {
            Console.WriteLine($"Day Scholar Student ID: {StudentId}, Name: {Name}");
        }
    }

    // Class representing a resident student
    public class Resident : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        // Constructor to initialize the resident's details
        public Resident(int stud_id, string s_name)
        {
            StudentId = stud_id;
            Name = s_name;
        }

        // Method to display the resident's details
        public void ShowDetails()
        {
            Console.WriteLine($"Resident Student ID: {StudentId}, Name: {Name}");
        }
    }
    class que4
    {
        public static void interstudentcalling()
        {
            string c_ans;
            do
            {
                Console.WriteLine("Please enter which students details you want to enter Day Scholar or Resident");
                Console.Write("For Day Scholar enter DS and For Resident enter R : ");
                string ans = Console.ReadLine();
                if (ans.ToLower() == "ds")
                {
                    Console.Write("Enter Student ID of day scholar student : ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Enter Name of day scholar student : ");
                    string name = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Day Scholar Student Details are : ");
                    IStudent dayscholar = new Dayscholar(id, name);
                    dayscholar.ShowDetails();
                }
                else if (ans.ToLower() == "r")
                {
                    Console.Write("Enter Student ID of resident student : ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Enter Name of resident student : ");
                    string name = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Resident Student Details are : ");
                    IStudent resident = new Resident(id, name);
                    resident.ShowDetails();
                }
                else
                {
                    Console.WriteLine("Enter valid Input");
                }
                Console.Write("Do you want to enter more student details (enter yes or no)");
                c_ans = Console.ReadLine();
            } while (c_ans.ToLower() == "yes");
        }
    }
}
