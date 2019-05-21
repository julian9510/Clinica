namespace WebAppVet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class metadata : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "FullName", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Clients", "Email", c => c.String(maxLength: 100));
            AlterColumn("dbo.Rooms", "Name", c => c.String(maxLength: 50));
            AlterColumn("dbo.Rooms", "Location", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rooms", "Location", c => c.String());
            AlterColumn("dbo.Rooms", "Name", c => c.String());
            AlterColumn("dbo.Clients", "Email", c => c.String());
            AlterColumn("dbo.Clients", "FullName", c => c.String());
        }
    }
}
