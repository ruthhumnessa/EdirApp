namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedFKtoCustomers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "EdirId", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "EdirId");
            AddForeignKey("dbo.Customers", "EdirId", "dbo.Edirs", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "EdirId", "dbo.Edirs");
            DropIndex("dbo.Customers", new[] { "EdirId" });
            DropColumn("dbo.Customers", "EdirId");
        }
    }
}
