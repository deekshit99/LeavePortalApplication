namespace EmployeeLeavePortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRegisterProp1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String(nullable: false, maxLength: 250));
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String(nullable: false, maxLength: 250));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirstName");
        }
    }
}
