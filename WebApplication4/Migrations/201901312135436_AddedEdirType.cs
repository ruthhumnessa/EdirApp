namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedEdirType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EdirTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        SignUpFee = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DurationInMonths = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Edirs", "EdirTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Edirs", "EdirTypeId");
            AddForeignKey("dbo.Edirs", "EdirTypeId", "dbo.EdirTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Edirs", "EdirTypeId", "dbo.EdirTypes");
            DropIndex("dbo.Edirs", new[] { "EdirTypeId" });
            DropColumn("dbo.Edirs", "EdirTypeId");
            DropTable("dbo.EdirTypes");
        }
    }
}
