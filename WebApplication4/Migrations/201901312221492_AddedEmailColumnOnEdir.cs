namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedEmailColumnOnEdir : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Edirs", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Edirs", "Email");
        }
    }
}
