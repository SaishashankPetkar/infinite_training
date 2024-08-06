using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RailwayReservationSystem.Models;

namespace RailwayReservationSystem
{
    class AdminDashboard
    {
        static RailwayReservationSystemDBContext db = new RailwayReservationSystemDBContext();
        public static void A_Dashboard()
        {
            bool validChoice = false;

            while (!validChoice)
            {
                Console.WriteLine();
                Console.WriteLine("Select which admin task you want to perform:");
                Console.WriteLine("1. Add Train");
                Console.WriteLine("2. Update Train Status");
                Console.WriteLine("3. View Trains");
                Console.WriteLine("4. View Bookings");
                Console.WriteLine("5. View Cancellations");
                Console.WriteLine("6. Exit Admin Dashboard");
                Console.Write("Enter your choice (1 or 2 or 3 or 4 or 5): ");
                Train train = new Train();
                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            bool trainaddvaild = false;
                            while (!trainaddvaild)
                            {
                                try
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Hello Admin Of Railway Reservation System !");
                                    Console.WriteLine("Please Fill The Train Details:-");
                                    Console.Write("Enter Train Number: ");
                                    int t_no = Convert.ToInt32(Console.ReadLine());
                                    train.train_no = t_no;
                                    Console.Write("Enter Train Name: ");
                                    train.train_name = Console.ReadLine();
                                    Console.Write("Enter Train Starting Point: ");
                                    train.train_starting_point = Console.ReadLine();
                                    Console.Write("Enter Train Ending Point: ");
                                    train.train_ending_point = Console.ReadLine();
                                    Console.Write("Enter Number of Seats Avilable for Train's Sleeper Class(Enter 0 if class not avaliable): ");
                                    train.seats_sleeper_class = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Enter Price for Train's Sleeper Class(Enter 0 if class not avaliable): ");
                                    train.sleeper_class_price = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Enter Number of Seats Avilable for Train's Ac First Class(Enter 0 if class not avaliable): ");
                                    train.seats_firstAC_class = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Enter Price for Train's Ac First Class(Enter 0 if class not avaliable): ");
                                    train.firstAC_class_price = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Enter Number of Seats Avilable for Train's Ac Second Class(Enter 0 if class not avaliable): ");
                                    train.seats_secondAC_class = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Enter Price for Train's Ac Second Class(Enter 0 if class not avaliable): ");
                                    train.secondAC_class_price = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Enter Number of Seats Avilable for Train's Ac Third Class(Enter 0 if class not avaliable): ");
                                    train.seats_thirdAC_class = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Enter Price for Train's Ac Third Class(Enter 0 if class not avaliable): ");
                                    train.thirdAC_class_price = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Enter Status Of Train (Active or Inactive): ");
                                    string status = Console.ReadLine();
                                    if(status.ToLower()=="active" || status.ToLower() == "inactive")
                                    {
                                        train.train_status = status;
                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("Please enter a valid status (Active or Inactive) !");
                                        break;
                                    }
                                    db.trains.Add(train);
                                    db.SaveChanges();
                                    Console.WriteLine();
                                    Console.WriteLine("Train Added Sucessfuly !");
                                    trainaddvaild = true;

                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("Train Already Exits or Error Occured :" + e.Message);
                                    break;
                                }
                            }
                            break;

                        case 2:
                            Console.WriteLine();
                            Console.WriteLine("Hello Admin Of Railway Reservation System !");
                            Console.WriteLine("Please Enter Train Details Whose Status You Want to Update:-");
                            Console.Write("Enter Train Number Whose Status You Want To Update: ");
                            try
                            {
                                int train_no = Convert.ToInt32(Console.ReadLine());
                                var train_details = db.trains
                                                    .FirstOrDefault(t => t.train_no == train_no);
                                if (train_details != null)
                                {
                                    Console.WriteLine();
                                    Console.Write("Enter New Status Of Train (Active or Inactive): ");
                                    string newstatus = Console.ReadLine();
                                    if (newstatus.ToLower() == "active" || newstatus.ToLower() == "inactive")
                                    {
                                        train_details.train_status = newstatus;
                                        db.SaveChanges();
                                        Console.WriteLine();
                                        Console.WriteLine("Train Status Updated Sucessfully");
                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("Please enter a valid status (Active or Inactive) !");
                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("No Train Found !");
                                    break;
                                }
                                
                            }
                            catch(Exception e)
                            {
                                Console.WriteLine("Error Occured : "+e.Message);
                            }
                            break;

                        case 3:
                            var train_dets= from t in db.trains
                                            select t;
                            Console.WriteLine();
                            Console.WriteLine("Trains Details Are As Follows: ");
                            foreach (var ele in train_dets)
                            {
                                Console.WriteLine($"Details of Train are :");
                                Console.WriteLine($"Train Number: {ele.train_no}");
                                Console.WriteLine($"Train Name: {ele.train_name}");
                                Console.WriteLine($"Starting Point: {ele.train_starting_point}");
                                Console.WriteLine($"Ending Point: {ele.train_ending_point}");
                                Console.WriteLine($"Seats Sleeper Class: {ele.seats_sleeper_class}");
                                Console.WriteLine($"Sleeper Class Price: Rs.{ele.sleeper_class_price.ToString("F2")}");
                                Console.WriteLine($"Seats First AC Class: {ele.seats_firstAC_class}");
                                Console.WriteLine($"First AC Class Price: Rs.{ele.firstAC_class_price.ToString("F2")}");
                                Console.WriteLine($"Seats Second AC Class: {ele.seats_secondAC_class}");
                                Console.WriteLine($"Second AC Class Price: Rs.{ele.secondAC_class_price.ToString("F2")}");
                                Console.WriteLine($"Seats Third AC Class: {ele.seats_thirdAC_class}");
                                Console.WriteLine($"Third AC Class Price: Rs.{ele.thirdAC_class_price.ToString("F2")}");
                                Console.WriteLine($"Train Status Is: {ele.train_status}");
                                Console.WriteLine();
                            }
                            break;

                        case 4:
                            Console.WriteLine();
                            Console.WriteLine("Displaying All Bookings Data");
                            var bookings_data = from b in db.bookings
                                                select b;
                            Console.WriteLine();
                            Console.WriteLine("Booking Details Are :");
                            foreach (var booking_d in bookings_data)
                            {
                                Console.WriteLine($"Booking ID : {booking_d.BookingId}");
                                Console.WriteLine($"Train Number : {booking_d.train_no}");
                                Console.WriteLine($"User ID : {booking_d.User_id}");
                                Console.WriteLine($"Booking Date : {booking_d.BookingDate}");
                                Console.WriteLine($"Number Of Seats Booked : {booking_d.NumberOfSeats}");
                                Console.WriteLine($"Class Of Travel : {booking_d.ClassOfTravel}");
                                Console.WriteLine($"Total Price Of Ticket : {booking_d.TotalPrice}");
                            }

                            break;

                        case 5:
                            Console.WriteLine();
                            Console.WriteLine("Displaying All Cancellations Data:");

                            var allCancellations = db.cancellations.ToList();

                            if (allCancellations.Count == 0)
                            {
                                Console.WriteLine("No cancellations found.");
                                return;
                            }

                            foreach (var cancellation in allCancellations)
                            {
                                var booking = db.bookings.FirstOrDefault(b => b.BookingId == cancellation.BookingId);
                                if (booking != null)
                                {
                                    var train_data = db.trains.Find(booking.train_no);

                                    if (train_data != null)
                                    {
                                        double pricePerSeat = 0;

                                        switch (booking.ClassOfTravel.ToLower())
                                        {
                                            case "sleeper":
                                                pricePerSeat = train_data.sleeper_class_price;
                                                break;
                                            case "firstac":
                                                pricePerSeat = train_data.firstAC_class_price;
                                                break;
                                            case "secondac":
                                                pricePerSeat = train_data.secondAC_class_price;
                                                break;
                                            case "thirdac":
                                                pricePerSeat = train_data.thirdAC_class_price;
                                                break;
                                            default:
                                                Console.WriteLine("Invalid class of travel.");
                                                continue;
                                        }

                                        Console.WriteLine($"Cancellation ID: {cancellation.CancellationId}");
                                        Console.WriteLine($"Booking ID: {cancellation.BookingId}");
                                        Console.WriteLine($"Train Number: {booking.train_no}");
                                        Console.WriteLine($"Class of Travel: {booking.ClassOfTravel}");
                                        Console.WriteLine($"Number of Seats Cancelled: {cancellation.NumberOfSeatsCancelled}");
                                        Console.WriteLine($"Price That Has Been Refunded Is: {pricePerSeat * cancellation.NumberOfSeatsCancelled}");
                                        Console.WriteLine($"Cancellation Date: {cancellation.CancellationDate}");
                                        Console.WriteLine();
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Train details not found for Train Number: {booking.train_no}");
                                    }
                                }
                            }
                            break;

                        case 6:
                            Console.WriteLine();
                            Console.WriteLine("Redirecting To Home Dashboard...");
                            Home.homecall();
                            validChoice = true;
                            break;

                        default:
                            Console.WriteLine();
                            Console.WriteLine("Please Enter A valid choice");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }
    }
}
