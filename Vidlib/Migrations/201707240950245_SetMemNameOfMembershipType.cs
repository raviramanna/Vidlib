namespace Vidlib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetMemNameOfMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET MemName = 'Pay As You Go' WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET MemName = 'Monthly' WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET MemName = 'Quaterly' WHERE Id = 3");
            Sql("UPDATE MembershipTypes SET MemName = 'Annual' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
