namespace Analiz_monitorService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MarkParametrs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Mark = c.Int(nullable: false),
                        Plain = c.Int(nullable: false),
                        Working = c.Int(nullable: false),
                        Game = c.Int(nullable: false),
                        Professional = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MarkParametrs");
        }
    }
}
