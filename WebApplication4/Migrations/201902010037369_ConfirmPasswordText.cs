namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConfirmPasswordText : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Edirs", "ConfirmPassword", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Edirs", "ConfirmPassword");
        }
    }
}