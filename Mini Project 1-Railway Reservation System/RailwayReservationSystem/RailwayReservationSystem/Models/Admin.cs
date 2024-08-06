using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RailwayReservationSystem.Models
{
    [Table("Admin")]
    public class Admin
    {
        [Key]
        public int admin_id { get; set; }
        public string admin_user_name { get; set; }
        public string password { get; set; }
    }
}
