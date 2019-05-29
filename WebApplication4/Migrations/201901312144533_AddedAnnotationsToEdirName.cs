namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAnnotationsToEdirName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Edirs", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Edirs", "Name", c => c.String());
        }
    }
}
