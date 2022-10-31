namespace Analiz_monitorService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MarkParametrs", "Down", c => c.Int(nullable: false));
            AddColumn("dbo.MarkParametrs", "Average", c => c.Int(nullable: false));
            AddColumn("dbo.MarkParametrs", "Up", c => c.Int(nullable: false));
            DropColumn("dbo.MarkParametrs", "Plain");
            DropColumn("dbo.MarkParametrs", "Working");
            DropColumn("dbo.MarkParametrs", "Game");
            DropColumn("dbo.MarkParametrs", "Professional");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MarkParametrs", "Professional", c => c.Int(nullable: false));
            AddColumn("dbo.MarkParametrs", "Game", c => c.Int(nullable: false));
            AddColumn("dbo.MarkParametrs", "Working", c => c.Int(nullable: false));
            AddColumn("dbo.MarkParametrs", "Plain", c => c.Int(nullable: false));
            DropColumn("dbo.MarkParametrs", "Up");
            DropColumn("dbo.MarkParametrs", "Average");
            DropColumn("dbo.MarkParametrs", "Down");
        }
    }
}
