using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace RailwayReservationSystem.Models
{
    class RailwayReservationSystemDBContext : DbContext
    {
        public RailwayReservationSystemDBContext() : base("name=RailwayReservationConnection") { }
        public DbSet<Users> users { get; set; }
        public DbSet<Admin> admins { get; set; }
        public DbSet<Train> trains { get; set; }
        public DbSet<Bookings> bookings { get; set; }
        public DbSet<Cancellation> cancellations { get; set; }
    }
}
