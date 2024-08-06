namespace RailwayReservationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TrainTableupdatesecondclass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trains", "seats_secondAC_class", c => c.Int(nullable: false));
            DropColumn("dbo.Trains", "seats_seconAC_class");
        }

        public override void Down()
        {
            AddColumn("dbo.Trains", "seats_seconAC_class", c => c.Int(nullable: false));
            DropColumn("dbo.Trains", "seats_secondAC_class");
        }
    }
}
