namespace EmployeeLeavePortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUserRolesData : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [FirstName], [LastName]) VALUES (N'73350d24-2fa3-4b5c-9adf-e1c9b209205e', N'admin@elp.com', 0, N'AO8mhp3r6IFoZjPGNyhIYMqKoizgznLTqzS+qYX0ky5Z/yb4+VRUkaC401bYWqfpcA==', N'572558a6-1b9a-4be6-87ba-dc25bce3894e', NULL, 0, 0, NULL, 1, 0, N'admin@elp.com', N'ashok ', N'polina')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [FirstName], [LastName]) VALUES (N'ec1c912e-5808-4ea7-8488-efe07ef6bc3c', N'naga@elp.com', 0, N'ALVKPNbskWiFLVqF7Iij02Gnx+vxiJ0m9LpnmlyjTUr7wTNy4APnZQ4pBTdNTii1wA==', N'd905971b-7954-47d2-8956-864240fc02a2', NULL, 0, 0, NULL, 1, 0, N'naga@elp.com', N'naga', N'prakhya')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ce38f58f-9dc7-4d1f-a71f-2d57c3c1e731', N'Admin')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'73350d24-2fa3-4b5c-9adf-e1c9b209205e', N'ce38f58f-9dc7-4d1f-a71f-2d57c3c1e731')


");
        }
        
        public override void Down()
        {
        }
    }
}
