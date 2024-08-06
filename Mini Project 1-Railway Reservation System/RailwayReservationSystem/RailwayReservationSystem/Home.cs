using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RailwayReservationSystem.Models;

namespace RailwayReservationSystem
{
    public class Home
    {
        static RailwayReservationSystemDBContext db = new RailwayReservationSystemDBContext();
        public static void homecall()
        {
            bool validChoice = false;
            Console.WriteLine("[ Welcome To Railway Reservation System ]");
            while (!validChoice)
            {
                Console.WriteLine();
                Console.WriteLine("Select your Login Option:");
                Console.WriteLine("1. User");
                Console.WriteLine("2. Admin");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice (1 or 2 or 3): ");

                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            bool uservalidchoice = false;
                            Console.WriteLine();
                            while (!uservalidchoice)
                            {
                                Console.WriteLine("Choose an option:");
                                Console.WriteLine("1. User login");
                                Console.WriteLine("2. User SignUp");
                                Console.WriteLine("3. Exit");
                                Console.Write("Enter your choice (1 or 2 or 3): ");
                                try
                                {
                                    int userchoice = Convert.ToInt32(Console.ReadLine());
                                    switch (userchoice)
                                    {
                                        case 1:
                                            Console.WriteLine();
                                            Console.Write("Enter Your Username : ");
                                            string uname = Console.ReadLine();
                                            Console.Write("Enter Your Password : ");
                                            string password = Console.ReadLine();
                                            bool userExists = db.users
                                                              .Any(Users => Users.user_name == uname && Users.password == password);
                                            if (userExists)
                                            {
                                                UserReservation.Reservation();
                                                uservalidchoice = true; // Exit the loop
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine("Incorrect Username or Password");
                                                break;
                                            }
                                        case 2:
                                            Users user = new Users();
                                            Console.WriteLine();
                                            Console.WriteLine("Welcome To Railway Reservation System !");
                                            Console.WriteLine("Please Fill SignUp Details:-");
                                            Console.Write("Enter Your Name :");
                                            user.name = Console.ReadLine();
                                            Console.Write("Enter Your Username :");
                                            user.user_name = Console.ReadLine();
                                            Console.Write("Enter Your Password :");
                                            user.password = Console.ReadLine();
                                            Console.Write("Enter Your Phone No. :");
                                            user.phone_no = Convert.ToDouble(Console.ReadLine());
                                            Console.Write("Enter Your Gender :");
                                            user.gender = Console.ReadLine();
                                            Console.Write("Enter Your Age :");
                                            user.age = Convert.ToInt32(Console.ReadLine());
                                            db.users.Add(user);
                                            db.SaveChanges();
                                            Console.WriteLine("User Created Successful Now Login From Home Dashboard :)");
                                            uservalidchoice = false; 
                                            Console.WriteLine();
                                            break;

                                        case 3:
                                            Console.WriteLine();
                                            Console.WriteLine("Are you sure you want to Exit !");
                                            Console.WriteLine("Press Enter to exit");
                                            uservalidchoice = true;
                                            break;

                                        default:
                                            Console.WriteLine();
                                            Console.WriteLine("Invalid choice. Please select 1 to log in or 2 to register.");
                                            // Do not exit the loop
                                            break;
                                    }
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Invalid input.Please Enter A Valid Input.");
                                }
                            }
                            validChoice = true;
                            break;

                        case 2:
                            Console.WriteLine();
                            Console.Write("Enter Admin Username : ");
                            string aname = Console.ReadLine();
                            Console.Write("Enter Admin Password : ");
                            string apassword = Console.ReadLine();
                            bool adminExists = db.admins
                                              .Any(Admin => Admin.admin_user_name == aname && Admin.password == apassword);
                            if (adminExists)
                            {
                                AdminDashboard.A_Dashboard();
                                validChoice = true; // Exit the loop
                                break;
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Incorrect Admin Username or Password");
                                break;
                            }

                        case 3:
                            Console.WriteLine();
                            Console.WriteLine("Are you sure you want to Exit !");
                            Console.WriteLine("Press Enter to exit");
                            validChoice = true;
                            break;

                        default:
                            Console.WriteLine();
                            Console.WriteLine("Invalid choice. Please select 1 for User or 2 for Admin.");
                            break;
                    }
                }
                catch(FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }
    }
}
