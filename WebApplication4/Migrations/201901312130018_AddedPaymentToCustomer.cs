namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPaymentToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Payment", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Payment");
        }
    }
}
