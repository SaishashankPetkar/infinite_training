namespace RailwayReservationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cancllationtableforignkeyupdate2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cancellation", "BookingId", "dbo.Bookings");
            DropIndex("dbo.Cancellation", new[] { "BookingId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Cancellation", "BookingId");
            AddForeignKey("dbo.Cancellation", "BookingId", "dbo.Bookings", "BookingId", cascadeDelete: true);
        }
    }
}
