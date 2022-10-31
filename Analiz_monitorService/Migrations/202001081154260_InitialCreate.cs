namespace Analiz_monitorService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Monitors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Diagonal = c.Int(nullable: false),
                        Resolution = c.String(nullable: false),
                        MatrixType = c.String(nullable: false),
                        ResponseTime = c.Int(nullable: false),
                        Frequency = c.Int(nullable: false),
                        HDTVSupport = c.Boolean(nullable: false),
                        HDCPSupport = c.Boolean(nullable: false),
                        PowerUsage = c.Int(nullable: false),
                        Curved = c.Boolean(nullable: false),
                        PowerSupply = c.String(nullable: false),
                        Assessment = c.Int(nullable: false),
                        BrandId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Brands", t => t.BrandId, cascadeDelete: true)
                .Index(t => t.BrandId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Monitors", "BrandId", "dbo.Brands");
            DropIndex("dbo.Monitors", new[] { "BrandId" });
            DropTable("dbo.Monitors");
            DropTable("dbo.Brands");
        }
    }
}
