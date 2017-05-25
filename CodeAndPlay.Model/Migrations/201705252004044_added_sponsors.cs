namespace CodeAndPlay.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_sponsors : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sponsors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        LogoUrl = c.String(nullable: false),
                        SiteUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sponsors");
        }
    }
}
