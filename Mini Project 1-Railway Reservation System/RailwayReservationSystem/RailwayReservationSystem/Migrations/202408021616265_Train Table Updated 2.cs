namespace RailwayReservationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TrainTableUpdated2 : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.Trains", "train_num", c => c.Int(nullable: false));
        }

        public override void Down()
        {
            //DropColumn("dbo.Trains", "train_num");
        }
    }
}
