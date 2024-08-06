namespace RailwayReservationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TrainTableUpdatedPriceadded : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.Trains", "sleeper_class_price", c => c.Double(nullable: false));
            //AddColumn("dbo.Trains", "firstAC_class_price", c => c.Double(nullable: false));
            //AddColumn("dbo.Trains", "secondAC_class_price", c => c.Double(nullable: false));
            //AddColumn("dbo.Trains", "thirdAC_class_price", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            //DropColumn("dbo.Trains", "thirdAC_class_price");
            //DropColumn("dbo.Trains", "secondAC_class_price");
            //DropColumn("dbo.Trains", "firstAC_class_price");
            //DropColumn("dbo.Trains", "sleeper_class_price");
        }
    }
}
