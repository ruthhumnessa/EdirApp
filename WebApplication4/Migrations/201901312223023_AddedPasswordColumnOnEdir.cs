namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPasswordColumnOnEdir : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Edirs", "Password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Edirs", "Password");
        }
    }
}
