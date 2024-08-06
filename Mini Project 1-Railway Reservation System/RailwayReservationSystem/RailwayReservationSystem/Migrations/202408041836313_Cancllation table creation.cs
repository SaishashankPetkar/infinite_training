namespace RailwayReservationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cancllationtablecreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CancellationId",
                c => new
                    {
                        CancellationId = c.Int(nullable: false, identity: true),
                        BookingId = c.Int(nullable: false),
                        CancellationDate = c.DateTime(nullable: false),
                        NumberOfSeatsCancelled = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CancellationId)
                .ForeignKey("dbo.Bookings", t => t.BookingId, cascadeDelete: true)
                .Index(t => t.BookingId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CancellationId", "BookingId", "dbo.Bookings");
            DropIndex("dbo.CancellationId", new[] { "BookingId" });
            DropTable("dbo.CancellationId");
        }
    }
}
