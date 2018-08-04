namespace Vidley.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameColumnToMemberShipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MemberShipTypes", "Name", c => c.String());
            Sql("update  MemberShipTypes set Name='Pay As You Go' where Id=1");
            Sql("update  MemberShipTypes set Name='Monthly' where Id=2");
            Sql("update  MemberShipTypes set Name='Quarterly' where Id=3");
            Sql("update  MemberShipTypes set Name='Yearly' where Id=4");
        }
        
        public override void Down()
        {
            DropColumn("dbo.MemberShipTypes", "Name");
        }
    }
}
