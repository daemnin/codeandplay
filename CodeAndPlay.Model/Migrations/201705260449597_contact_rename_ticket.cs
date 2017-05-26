namespace CodeAndPlay.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class contact_rename_ticket : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Contacts", newName: "Tickets");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Tickets", newName: "Contacts");
        }
    }
}
