namespace Funfik.Core.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatabaseInitialization : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ArticleRates",
                c => new
                    {
                        ArticleRateId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        ArticleId = c.Int(nullable: false),
                        Rate = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ArticleRateId)
                .ForeignKey("dbo.Articles", t => t.ArticleId, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: false)
                .Index(t => t.ArticleId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        ArticleId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Title = c.String(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        LastEditDate = c.DateTime(nullable: false),
                        Category_CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ArticleId)
                .ForeignKey("dbo.Categories", t => t.Category_CategoryId, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: false)
                .Index(t => t.Category_CategoryId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Chapters",
                c => new
                    {
                        ChapterId = c.Int(nullable: false, identity: true),
                        ArticleId = c.Int(nullable: false),
                        Text = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ChapterId)
                .ForeignKey("dbo.Articles", t => t.ArticleId, cascadeDelete: false)
                .Index(t => t.ArticleId);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        TagId = c.Int(nullable: false, identity: true),
                        ArticleId = c.Int(nullable: false),
                        Title = c.String(nullable: false),
                        UsageCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TagId)
                .ForeignKey("dbo.Articles", t => t.ArticleId, cascadeDelete: false)
                .Index(t => t.ArticleId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Articles", "UserId", "dbo.Users");
            DropForeignKey("dbo.ArticleRates", "UserId", "dbo.Users");
            DropForeignKey("dbo.Tags", "ArticleId", "dbo.Articles");
            DropForeignKey("dbo.Chapters", "ArticleId", "dbo.Articles");
            DropForeignKey("dbo.Articles", "Category_CategoryId", "dbo.Categories");
            DropForeignKey("dbo.ArticleRates", "ArticleId", "dbo.Articles");
            DropIndex("dbo.Articles", new[] { "UserId" });
            DropIndex("dbo.ArticleRates", new[] { "UserId" });
            DropIndex("dbo.Tags", new[] { "ArticleId" });
            DropIndex("dbo.Chapters", new[] { "ArticleId" });
            DropIndex("dbo.Articles", new[] { "Category_CategoryId" });
            DropIndex("dbo.ArticleRates", new[] { "ArticleId" });
            DropTable("dbo.Users");
            DropTable("dbo.Tags");
            DropTable("dbo.Chapters");
            DropTable("dbo.Categories");
            DropTable("dbo.Articles");
            DropTable("dbo.ArticleRates");
        }
    }
}
