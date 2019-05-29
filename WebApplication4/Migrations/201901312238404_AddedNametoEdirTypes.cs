namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNametoEdirTypes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EdirTypes", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.EdirTypes", "Name");
        }
    }
}
