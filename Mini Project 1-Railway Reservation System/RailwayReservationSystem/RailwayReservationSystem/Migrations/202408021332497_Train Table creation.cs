namespace RailwayReservationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TrainTablecreation : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.Trains",
            //    c => new
            //    {
            //        train_no = c.Int(nullable: false, identity: true),
            //        train_name = c.String(nullable: false),
            //        train_starting_point = c.String(nullable: false),
            //        train_ending_point = c.String(nullable: false),
            //        seats_sleeper_class = c.Int(nullable: false),
            //        seats_firstAC_class = c.Int(nullable: false),
            //        seats_seconAC_class = c.Int(nullable: false),
            //        seats_thirdAC_class = c.Int(nullable: false),
            //        train_status = c.String(nullable: false),
            //    })
            //    .PrimaryKey(t => t.train_no);

        }
        
        public override void Down()
        {
            //DropTable("dbo.Trains");
        }
    }
}
