namespace EmployeeLeavePortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateLeaveRequest : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeeViewModels",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.LeaveRequests", "Employee_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.LeaveRequests", "Employee_Id");
            AddForeignKey("dbo.LeaveRequests", "Employee_Id", "dbo.EmployeeViewModels", "Id");
            DropColumn("dbo.LeaveRequests", "Employee_FirstName");
            DropColumn("dbo.LeaveRequests", "Employee_LastName");
            DropColumn("dbo.LeaveRequests", "Employee_Email");
            DropColumn("dbo.LeaveRequests", "Employee_Password");
            DropColumn("dbo.LeaveRequests", "Employee_ConfirmPassword");
        }
        
        public override void Down()
        {
            AddColumn("dbo.LeaveRequests", "Employee_ConfirmPassword", c => c.String());
            AddColumn("dbo.LeaveRequests", "Employee_Password", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.LeaveRequests", "Employee_Email", c => c.String(nullable: false));
            AddColumn("dbo.LeaveRequests", "Employee_LastName", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.LeaveRequests", "Employee_FirstName", c => c.String(nullable: false, maxLength: 255));
            DropForeignKey("dbo.LeaveRequests", "Employee_Id", "dbo.EmployeeViewModels");
            DropIndex("dbo.LeaveRequests", new[] { "Employee_Id" });
            DropColumn("dbo.LeaveRequests", "Employee_Id");
            DropTable("dbo.EmployeeViewModels");
        }
    }
}
