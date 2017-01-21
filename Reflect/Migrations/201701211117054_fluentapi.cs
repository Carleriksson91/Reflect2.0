namespace Reflect.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fluentapi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.QuestionTags",
                c => new
                    {
                        QuestionId = c.Int(nullable: false),
                        TagId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.QuestionId, t.TagId })
                .ForeignKey("dbo.Tags", t => t.QuestionId, cascadeDelete: true)
                .ForeignKey("dbo.Questions", t => t.TagId, cascadeDelete: true)
                .Index(t => t.QuestionId)
                .Index(t => t.TagId);
            
            AddColumn("dbo.QuestionAlternatives", "QuestionId", c => c.Int(nullable: false));
            AlterColumn("dbo.Questions", "ApplicationUserId", c => c.Guid());
            CreateIndex("dbo.QuestionAlternatives", "QuestionId");
            AddForeignKey("dbo.QuestionAlternatives", "QuestionId", "dbo.Questions", "QuestionId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.QuestionAlternatives", "QuestionId", "dbo.Questions");
            DropForeignKey("dbo.QuestionTags", "TagId", "dbo.Questions");
            DropForeignKey("dbo.QuestionTags", "QuestionId", "dbo.Tags");
            DropIndex("dbo.QuestionTags", new[] { "TagId" });
            DropIndex("dbo.QuestionTags", new[] { "QuestionId" });
            DropIndex("dbo.QuestionAlternatives", new[] { "QuestionId" });
            AlterColumn("dbo.Questions", "ApplicationUserId", c => c.Guid(nullable: false));
            DropColumn("dbo.QuestionAlternatives", "QuestionId");
            DropTable("dbo.QuestionTags");
        }
    }
}
