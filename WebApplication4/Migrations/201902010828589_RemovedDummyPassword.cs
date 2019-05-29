namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedDummyPassword : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Edirs", "Password");
            DropColumn("dbo.Edirs", "ConfirmPassword");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Edirs", "ConfirmPassword", c => c.String());
            AddColumn("dbo.Edirs", "Password", c => c.String());
        }
    }
}
