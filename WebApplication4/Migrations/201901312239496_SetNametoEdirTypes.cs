namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetNametoEdirTypes : DbMigration
    {
        public override void Up()
        {

            Sql("UPDATE EdirTypes SET Name = 'Community' WHERE Id = 1");
            Sql("UPDATE EdirTypes SET Name = 'Church' WHERE Id = 2");
            Sql("UPDATE EdirTypes SET Name = 'Women' WHERE Id = 3");
        }
    
    
        
        public override void Down()
        {
        }
    }
}
