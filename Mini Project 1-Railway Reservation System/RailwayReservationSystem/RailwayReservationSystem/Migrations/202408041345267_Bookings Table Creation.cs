namespace RailwayReservationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BookingsTableCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        BookingId = c.Int(nullable: false, identity: true),
                        train_no = c.Int(nullable: false),
                        user_id = c.String(nullable: false),
                        BookingDate = c.DateTime(nullable: false),
                        NumberOfSeats = c.Int(nullable: false),
                        ClassOfTravel = c.String(nullable: false),
                        TotalPrice = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.BookingId)
                .ForeignKey("dbo.Trains", t => t.train_no, cascadeDelete: true)
                .Index(t => t.train_no);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bookings", "train_no", "dbo.Trains");
            DropIndex("dbo.Bookings", new[] { "train_no" });
            DropTable("dbo.Bookings");
        }
    }
}
