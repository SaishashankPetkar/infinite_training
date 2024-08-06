using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RailwayReservationSystem.Models
{
    [Table("Trains")]
    public class Train
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int train_no { get; set; }
        [Required]
        public string train_name { get; set; }
        [Required]
        public string train_starting_point { get; set; }
        [Required]
        public string train_ending_point { get; set; }
        public int seats_sleeper_class { get; set; }
        public double sleeper_class_price { get; set; }
        public int seats_firstAC_class { get; set; }
        public double firstAC_class_price { get; set; }
        public int seats_secondAC_class { get; set; }
        public double secondAC_class_price { get; set; }
        public int seats_thirdAC_class { get; set; }
        public double thirdAC_class_price { get; set; }
        [Required]
        public string train_status { get; set; }

    }
}
