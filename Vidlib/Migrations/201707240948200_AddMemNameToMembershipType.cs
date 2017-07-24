namespace Vidlib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMemNameToMembershipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "MemName", c => c.String());
            DropColumn("dbo.MembershipTypes", "MembershipName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "MembershipName", c => c.String());
            DropColumn("dbo.MembershipTypes", "MemName");
        }
    }
}
