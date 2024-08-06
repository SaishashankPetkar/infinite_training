namespace RailwayReservationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdminTablecreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admin",
                c => new
                    {
                        admin_id = c.Int(nullable: false, identity: true),
                        admin_user_name = c.String(),
                        password = c.String(),
                    })
                .PrimaryKey(t => t.admin_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Admin");
        }
    }
}
