namespace Reflect.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addmigrationc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ApplicationUserId = c.Int(nullable: false),
                        ApplicationUser_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            AddColumn("dbo.Answers", "User_Id", c => c.Int());
            AddColumn("dbo.AspNetUsers", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Answers", "User_Id");
            AddForeignKey("dbo.Answers", "User_Id", "dbo.Users", "Id");
            DropColumn("dbo.Tags", "QuestionId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tags", "QuestionId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Users", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Answers", "User_Id", "dbo.Users");
            DropIndex("dbo.Users", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Answers", new[] { "User_Id" });
            DropColumn("dbo.AspNetUsers", "UserId");
            DropColumn("dbo.Answers", "User_Id");
            DropTable("dbo.Users");
        }
    }
}
