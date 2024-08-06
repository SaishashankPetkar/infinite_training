namespace RailwayReservationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreat : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        user_id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        user_name = c.String(),
                        password = c.String(),
                        phone_no = c.Double(nullable: false),
                        gender = c.String(),
                        age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.user_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
