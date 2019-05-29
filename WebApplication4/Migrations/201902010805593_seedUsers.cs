namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4cda66dd-8b5c-43c0-834d-67e9ec4d7c3f', N'ediradmin@gmail.com', 0, N'ADzzmfla/SfbIORS7M3N7F1iSCTzMVZ57o+Bs4Vm21JGT9oBDkVWWnU+YQsG51p9yw==', N'1c4de0ef-b202-4493-92b4-fd28fc66b97a', NULL, 0, 0, NULL, 1, 0, N'ediradmin@gmail.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'50360afe-77d2-4e4d-ab5f-d00b135e9f38', N'ruthjchumnessa@gmail.com', 0, N'ANO8ZdbYvf3U6A8QosCGA5Kj/m7N/3u0coL70tYAEUp9NruOv21MMVMeMoIh/Pn95g==', N'3cc8584e-0bd1-4c42-80a9-bf009b004249', NULL, 0, 0, NULL, 1, 0, N'ruthjchumnessa@gmail.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'1a29dd0e-e037-493d-bd17-29fa3fcb7c97', N'CanManageEdirs')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4cda66dd-8b5c-43c0-834d-67e9ec4d7c3f', N'1a29dd0e-e037-493d-bd17-29fa3fcb7c97')
");
        }
        
        public override void Down()
        {
        }
    }
}
