using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayReservationSystem.Models
{
    [Table("Bookings")]
    class Bookings
    {
        [Key]
        public int BookingId { get; set; }

        [Required]
        public int train_no { get; set; }

        [ForeignKey("train_no")]
        public Train Train { get; set; }

        [Required]
        public int User_id { get; set; }

        [Required]
        public DateTime BookingDate { get; set; }

        [Required]
        public int NumberOfSeats { get; set; }

        [Required]
        public string ClassOfTravel { get; set; }

        [Required]
        public double TotalPrice { get; set; }
    }
}
