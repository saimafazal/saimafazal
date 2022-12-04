namespace clothbazaar.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialize : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.catregries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Name = c.String(),
                        description = c.String(),
                        catregry_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.catregries", t => t.catregry_ID)
                .Index(t => t.catregry_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.products", "catregry_ID", "dbo.catregries");
            DropIndex("dbo.products", new[] { "catregry_ID" });
            DropTable("dbo.products");
            DropTable("dbo.catregries");
        }
    }
}
