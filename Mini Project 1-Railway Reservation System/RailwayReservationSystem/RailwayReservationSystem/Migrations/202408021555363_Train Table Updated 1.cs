namespace RailwayReservationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TrainTableUpdated1 : DbMigration
    {
        public override void Up()
        {
            //DropPrimaryKey("dbo.Trains");
            //AddColumn("dbo.Trains", "train_index", c => c.Int(nullable: false, identity: true));
            //AlterColumn("dbo.Trains", "train_no", c => c.Int(nullable: false));
            //AddPrimaryKey("dbo.Trains", "train_index");
        }
        
        public override void Down()
        {
            //DropPrimaryKey("dbo.Trains");
            //AlterColumn("dbo.Trains", "train_no", c => c.Int(nullable: false, identity: true));
            //DropColumn("dbo.Trains", "train_index");
            //AddPrimaryKey("dbo.Trains", "train_no");
        }
    }
}
