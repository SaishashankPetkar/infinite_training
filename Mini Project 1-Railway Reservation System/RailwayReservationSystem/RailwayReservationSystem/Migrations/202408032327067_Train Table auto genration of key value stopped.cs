namespace RailwayReservationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TrainTableautogenrationofkeyvaluestopped : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Trains");
            AlterColumn("dbo.Trains", "train_no", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Trains", "train_no");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Trains");
            AlterColumn("dbo.Trains", "train_no", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Trains", "train_no");
        }
    }
}
