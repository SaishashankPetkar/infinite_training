using System;
using System.Linq;
using RailwayReservationSystem.Models;

namespace RailwayReservationSystem
{
    public class UserReservation
    {
        static RailwayReservationSystemDBContext db = new RailwayReservationSystemDBContext();

        public static void Reservation()
        {
            bool validChoice = false;

            while (!validChoice)
            {
                Console.WriteLine();
                Console.WriteLine("Select which transaction you want to perform:");
                Console.WriteLine("1. Book Tickets");
                Console.WriteLine("2. Cancel Tickets");
                Console.WriteLine("3. View Booked Tickets");
                Console.WriteLine("4. View Canceled Tickets");
                Console.WriteLine("5. Exit User Dashboard");
                Console.Write("Enter your choice (1 or 2 or 3 or 4 or 5): ");

                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            var train_details = from t in db.trains
                                                where t.train_status == "active"
                                                select t;
                            Console.WriteLine();
                            Console.WriteLine("Trains Details Are As Follows: ");
                            foreach (var train in train_details)
                            {
                                Console.WriteLine($"Details of Train are :");
                                Console.WriteLine($"Train Number: {train.train_no}");
                                Console.WriteLine($"Train Name: {train.train_name}");
                                Console.WriteLine($"Starting Point: {train.train_starting_point}");
                                Console.WriteLine($"Ending Point: {train.train_ending_point}");
                                Console.WriteLine($"Seats Sleeper Class: {train.seats_sleeper_class}");
                                Console.WriteLine($"Sleeper Class Price: Rs.{train.sleeper_class_price.ToString("F2")}");
                                Console.WriteLine($"Seats First AC Class: {train.seats_firstAC_class}");
                                Console.WriteLine($"First AC Class Price: Rs.{train.firstAC_class_price.ToString("F2")}");
                                Console.WriteLine($"Seats Second AC Class: {train.seats_secondAC_class}");
                                Console.WriteLine($"Second AC Class Price: Rs.{train.secondAC_class_price.ToString("F2")}");
                                Console.WriteLine($"Seats Third AC Class: {train.seats_thirdAC_class}");
                                Console.WriteLine($"Third AC Class Price: Rs.{train.thirdAC_class_price.ToString("F2")}");
                                Console.WriteLine();
                            }

                            Console.Write("Enter Train Number Whose Ticket You Want to Book: ");
                            int train_num = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter Class For Which You Want To Book Ticket (Sleeper, FirstAC, SecondAC, ThirdAC): ");
                            string book_class = Console.ReadLine();

                            Console.Write("Enter Number Of Tickets You Want To Book (Max 3 are allowed at a time): ");
                            int no_of_tickets = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter Your User Name To Book: ");
                            string uname = Console.ReadLine();

                            var user = db.users.FirstOrDefault(u => u.user_name == uname);
                            if (user != null)
                            {
                                int user_id = user.user_id;
                                BookTickets(user_id, train_num, no_of_tickets, book_class);
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Please Enter A Valid User Name !");
                            }
                            break;

                        case 2:
                            Console.WriteLine();
                            Console.Write("Enter Your User Name To View Your Bookings For Cancle Tickets : ");
                            string u_name = Console.ReadLine();
                            var user_d = db.users.FirstOrDefault(u => u.user_name == u_name);
                            int user_ID;
                            if(user_d != null)
                            {
                                user_ID = user_d.user_id;
                                var bookings_data = from bk in db.bookings
                                                    where bk.User_id == user_ID
                                                    select bk;
                                Console.WriteLine();
                                Console.WriteLine("Your Booking Details Are :");
                                Console.WriteLine();
                                foreach(var booking_d in bookings_data)
                                {
                                    Console.WriteLine($"Booking ID : {booking_d.BookingId}");
                                    Console.WriteLine($"Train Number : {booking_d.train_no}");
                                    Console.WriteLine($"Booking Date : {booking_d.BookingDate}");
                                    Console.WriteLine($"Number Of Seats Booked : {booking_d.NumberOfSeats}");
                                    Console.WriteLine($"Class Of Travel : {booking_d.ClassOfTravel}");
                                    Console.WriteLine($"Total Price Of Ticket : {booking_d.TotalPrice}");
                                } 
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Enter A Valid User Name !");
                            }
                            Console.WriteLine();
                            Console.Write("Do you want to cancle the whole ticket or cancle the partial ticket (Enter Whole or Partial) : ");
                            string cancle_choice = Console.ReadLine();
                            if(cancle_choice.ToLower() == "whole")
                            {
                                Console.WriteLine();
                                Console.Write("Enter The booking Id Which You Want To Cancle: ");
                                int booking_id = Convert.ToInt32(Console.ReadLine());
                                Cancel_Whole_Ticket(booking_id);
                            }
                            else if(cancle_choice.ToLower() == "partial")
                            {
                                Console.WriteLine();
                                Console.Write("Enter The booking Id For Which You Want To Do Partial Cancle: ");
                                int booking_id = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter Number Of Seats You Want to Cancle (Should Be Less Than 3) : ");
                                int seats_to_cancle = Convert.ToInt32(Console.ReadLine());
                                if (seats_to_cancle < 3)
                                {
                                    Cancle_Partial_Ticket(booking_id, seats_to_cancle);
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Cannot Cancle Partial If Number Of Seats Is 3 !");
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Please Enter A Valid Choice (Whole or Partial) !");
                                break;
                            }
                            break;

                        case 3:
                            Console.WriteLine();
                            Console.Write("Enter Your User Name To View Your Bookings : ");
                            string usr_name = Console.ReadLine();
                            var user_data = db.users.FirstOrDefault(u => u.user_name == usr_name);
                            int usr_ID;
                            if (user_data != null)
                            {
                                usr_ID = user_data.user_id;
                                var bookings_data = from b in db.bookings
                                                    where b.User_id == usr_ID
                                                    select b;

                                Console.WriteLine();
                                if (!bookings_data.Any())
                                {
                                    Console.WriteLine("You have no bookings.");
                                }
                                else
                                {
                                    Console.WriteLine("Your Booking Details Are :");
                                    foreach (var booking_d in bookings_data)
                                    {
                                        Console.WriteLine($"Booking ID : {booking_d.BookingId}");
                                        Console.WriteLine($"Train Number : {booking_d.train_no}");
                                        Console.WriteLine($"Booking Date : {booking_d.BookingDate}");
                                        Console.WriteLine($"Number Of Seats Booked : {booking_d.NumberOfSeats}");
                                        Console.WriteLine($"Class Of Travel : {booking_d.ClassOfTravel}");
                                        Console.WriteLine($"Total Price Of Ticket : {booking_d.TotalPrice}");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Enter A Valid User Name !");
                            }
                            break;

                        case 4:
                            Console.WriteLine();
                            Console.Write("Enter Your User Name To View Your Cancellations: ");
                            string ur_name = Console.ReadLine();

                            
                            var ur_data = db.users.FirstOrDefault(u => u.user_name == ur_name);

                            if (ur_data != null)
                            {
                                
                                var userBookings = db.bookings
                                    .Where(b => b.User_id == ur_data.user_id)
                                    .ToList();

                                if (userBookings.Count == 0)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("No Cancellation found for this user.");
                                    Reservation();
                                }

                                var userBookingIds = userBookings.Select(b => b.BookingId).ToList();
                                var cancellations = db.cancellations
                                    .Where(c => userBookingIds.Contains(c.BookingId))
                                    .ToList();

                                if (cancellations.Count == 0)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("No cancellations found for your bookings.");
                                    return;
                                }

                                Console.WriteLine();
                                Console.WriteLine("Cancellation Details Are As Follows:");
                                foreach (var cancellation in cancellations)
                                {
                                    var booking = userBookings.FirstOrDefault(b => b.BookingId == cancellation.BookingId);
                                    if (booking != null)
                                    {
                                        var train = db.trains.Find(booking.train_no);

                                        if (train != null)
                                        {
                                            double pricePerSeat = 0;

                                            switch (booking.ClassOfTravel.ToLower())
                                            {
                                                case "sleeper":
                                                    pricePerSeat = train.sleeper_class_price;
                                                    break;
                                                case "firstac":
                                                    pricePerSeat = train.firstAC_class_price;
                                                    break;
                                                case "secondac":
                                                    pricePerSeat = train.secondAC_class_price;
                                                    break;
                                                case "thirdac":
                                                    pricePerSeat = train.thirdAC_class_price;
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
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("User not found. Please check the username and try again.");
                            }

                            break;

                        case 5:
                            Console.WriteLine();
                            Console.WriteLine("Redirecting To Home Dashboard...");
                            Home.homecall();
                            validChoice = true;
                            break;

                        default:
                            Console.WriteLine();
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error Occurred: " + e.Message);
                }
            }
        }

        public static void BookTickets(int userId, int trainNo, int numberOfSeats, string classOfTravel)
        {
            if (numberOfSeats > 3)
            {
                Console.WriteLine();
                Console.WriteLine("Cannot book more than 3 seats at once.");
                return;
            }
            var train = db.trains.Find(trainNo);
            if (train != null)
            {
                bool seatsAvailable = false;
                double pricePerSeat = 0;
                int seatsAvailableBefore = 0;

                switch (classOfTravel.ToLower())
                {
                    case "sleeper":
                        seatsAvailableBefore = train.seats_sleeper_class;
                        if (seatsAvailableBefore >= numberOfSeats)
                        {
                            seatsAvailable = true;
                            pricePerSeat = train.sleeper_class_price;
                            train.seats_sleeper_class -= numberOfSeats;
                        }
                        break;

                    case "firstac":
                        seatsAvailableBefore = train.seats_firstAC_class;
                        if (seatsAvailableBefore >= numberOfSeats)
                        {
                            seatsAvailable = true;
                            pricePerSeat = train.firstAC_class_price;
                            train.seats_firstAC_class -= numberOfSeats;
                        }
                        break;

                    case "secondac":
                        seatsAvailableBefore = train.seats_secondAC_class;
                        if (seatsAvailableBefore >= numberOfSeats)
                        {
                            seatsAvailable = true;
                            pricePerSeat = train.secondAC_class_price;
                            train.seats_secondAC_class -= numberOfSeats;
                        }
                        break;

                    case "thirdac":
                        seatsAvailableBefore = train.seats_thirdAC_class;
                        if (seatsAvailableBefore >= numberOfSeats)
                        {
                            seatsAvailable = true;
                            pricePerSeat = train.thirdAC_class_price;
                            train.seats_thirdAC_class -= numberOfSeats;
                        }
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("A Valid Class of Travel Not Supplied !");
                        return;
                }

                if (!seatsAvailable)
                {
                    Console.WriteLine();
                    Console.WriteLine("Not Enough Seats Are Available In Selected Class!");
                    return;
                }
                Console.WriteLine();
                Console.WriteLine($"Number Seats Booked Are : {numberOfSeats}");
                double totalprice = pricePerSeat * numberOfSeats;
                Console.WriteLine($"Total Price To Be Paid Is: {totalprice}");

                var booking = new Bookings
                {
                    train_no = trainNo,
                    User_id = userId,
                    BookingDate = DateTime.Now,
                    NumberOfSeats = numberOfSeats,
                    ClassOfTravel = classOfTravel,
                    TotalPrice = totalprice
                };

                db.bookings.Add(booking);
                db.SaveChanges();
                Console.WriteLine();
                Console.WriteLine($"Booking For Train No.: {trainNo}, Total Number Seats Booked: {numberOfSeats}, With Total Price: {totalprice} is Successful");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Train Not Found!");
            }
        }
        public static void Cancel_Whole_Ticket(int bookingId)
        {
            var bookings = db.bookings.Find(bookingId);
            if (bookings == null)
            {
                Console.WriteLine();
                Console.WriteLine("Booking ID Not Found");
                return;
            }
            else
            {
                var cancellation = new Cancellation
                {
                    BookingId = bookingId,
                    CancellationDate = DateTime.Now,
                    NumberOfSeatsCancelled = bookings.NumberOfSeats
                };
                var train_details = db.trains.Find(bookings.train_no);
                switch (bookings.ClassOfTravel.ToLower())
                {
                    case "sleeper":
                        train_details.seats_sleeper_class += bookings.NumberOfSeats;
                        break;
                    case "firstac":
                        train_details.seats_firstAC_class += bookings.NumberOfSeats;
                        break;
                    case "secondac":
                        train_details.seats_secondAC_class += bookings.NumberOfSeats;
                        break;
                    case "thirdac":
                        train_details.seats_thirdAC_class += bookings.NumberOfSeats;
                        break;
                }
                try
                {
                    db.cancellations.Add(cancellation);
                    db.bookings.Remove(bookings);
                    db.SaveChanges();
                    Console.WriteLine();
                    Console.WriteLine($"Booking ID : {bookingId}, Class Of Travel : {bookings.ClassOfTravel}, Number Of Seats : {bookings.NumberOfSeats}, " +
                        $"Total Ticket Price That will be Refunded : {bookings.TotalPrice}, Train Number : {bookings.train_no} has been successfully Cancelled!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error occurred while cancelling the booking: " + ex.Message);
                }
            }
            
        }
        public static void Cancle_Partial_Ticket(int bookingId,int Number_of_Seats)
        {
            var bookings = db.bookings.Find(bookingId);
            if (bookings == null)
            {
                Console.WriteLine();
                Console.WriteLine("Booking ID Not Found");
                return;
            }
            else
            {
                double pricePerSeat = 0;
                var cancellation = new Cancellation
                {
                    BookingId = bookingId,
                    CancellationDate = DateTime.Now,
                    NumberOfSeatsCancelled = Number_of_Seats
                };
                var train_details = db.trains.Find(bookings.train_no);
                switch (bookings.ClassOfTravel.ToLower())
                {
                    case "sleeper":
                        train_details.seats_sleeper_class += Number_of_Seats;
                        pricePerSeat = train_details.sleeper_class_price;
                        break;
                    case "firstac":
                        train_details.seats_firstAC_class += Number_of_Seats;
                        pricePerSeat = train_details.firstAC_class_price;
                        break;
                    case "secondac":
                        train_details.seats_secondAC_class += Number_of_Seats;
                        pricePerSeat = train_details.secondAC_class_price;
                        break;
                    case "thirdac":
                        train_details.seats_thirdAC_class += Number_of_Seats;
                        pricePerSeat = train_details.thirdAC_class_price;
                        break;
                }
                try
                {
                    bookings.NumberOfSeats -= Number_of_Seats;
                    bookings.TotalPrice -= pricePerSeat * Number_of_Seats; 
                    db.cancellations.Add(cancellation);
                    db.SaveChanges();
                    Console.WriteLine();
                    Console.WriteLine($"Booking ID : {bookingId}, Class Of Travel : {bookings.ClassOfTravel}, Number Of Seats : {Number_of_Seats}, " +
                        $"Total Ticket Price That will be Refunded : {pricePerSeat*Number_of_Seats}, Train Number : {bookings.train_no} has been successfully Cancelled!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error occurred while cancelling the booking: " + ex.Message);
                }
            }

        }
    }
}
