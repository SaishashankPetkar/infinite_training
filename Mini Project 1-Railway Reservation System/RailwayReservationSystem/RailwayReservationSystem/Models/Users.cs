using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RailwayReservationSystem.Models
{
    [Table("Users")]
    public class Users
    {
        [Key]
        public int user_id { get; set; }
        public string name { get; set; }
        public string user_name { get; set; }
        public string password { get; set; }
        public double phone_no { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
    }
}
