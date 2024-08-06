using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayReservationSystem.Models
{
    [Table("Cancellation")]
    class Cancellation
    {
        [Key]
        public int CancellationId { get; set; }

        [Required]
        public int BookingId { get; set; }

        [Required]
        public DateTime CancellationDate { get; set; }

        [Required]
        public int NumberOfSeatsCancelled { get; set; }
    }
}
