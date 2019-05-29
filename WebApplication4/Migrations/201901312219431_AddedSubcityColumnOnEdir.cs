namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedSubcityColumnOnEdir : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Edirs", "Subcity", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Edirs", "Subcity");
        }
    }
}
