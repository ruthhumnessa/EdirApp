namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedWeredaColumnOnEdir : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Edirs", "Wereda", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Edirs", "Wereda");
        }
    }
}
