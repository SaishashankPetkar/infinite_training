namespace RailwayReservationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cancllationtablenameupdate : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.CancellationId", newName: "Cancellation");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Cancellation", newName: "CancellationId");
        }
    }
}
