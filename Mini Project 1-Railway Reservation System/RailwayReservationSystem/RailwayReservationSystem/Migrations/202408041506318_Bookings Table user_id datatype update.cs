namespace RailwayReservationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BookingsTableuser_iddatatypeupdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bookings", "user_id", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Bookings", "user_id", c => c.String(nullable: false));
        }
    }
}
