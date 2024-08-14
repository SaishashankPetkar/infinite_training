﻿namespace CC1_Code_First.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Mid = c.Int(nullable: false, identity: true),
                        Moviename = c.String(),
                        DateofRelease = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Mid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Movies");
        }
    }
}
