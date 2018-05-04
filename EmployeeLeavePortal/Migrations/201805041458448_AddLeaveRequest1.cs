namespace EmployeeLeavePortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLeaveRequest1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LeaveRequests",
                c => new
                    {
                        LeaveRequestId = c.Int(nullable: false, identity: true),
                        From = c.DateTime(nullable: false),
                        To = c.DateTime(nullable: false),
                        NumDays = c.Int(nullable: false),
                        Comments = c.String(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        LastModifiedDate = c.DateTime(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        Employee_FirstName = c.String(nullable: false, maxLength: 255),
                        Employee_LastName = c.String(nullable: false, maxLength: 255),
                        Employee_Email = c.String(nullable: false),
                        Employee_Password = c.String(nullable: false, maxLength: 100),
                        Employee_ConfirmPassword = c.String(),
                    })
                .PrimaryKey(t => t.LeaveRequestId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LeaveRequests");
        }
    }
}
