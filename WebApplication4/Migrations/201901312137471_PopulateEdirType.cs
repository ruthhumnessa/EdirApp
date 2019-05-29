namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateEdirType : DbMigration
    {
        public override void Up()
        {
            Sql("insert into EdirTypes(Id, SignUpFee, DurationInMonths) values(1,50,1)");
            Sql("insert into EdirTypes(Id, SignUpFee, DurationInMonths) values(2,60,3)");
            Sql("insert into EdirTypes(Id, SignUpFee, DurationInMonths) values(3,100,2)");
        }
        
        public override void Down()
        {
        }
    }
}
