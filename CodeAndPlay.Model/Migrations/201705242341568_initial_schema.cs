namespace CodeAndPlay.Model.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class initial_schema : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendances",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Timestamp = c.DateTime(nullable: false),
                    StudentId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId);

            CreateTable(
                "dbo.Students",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    ControlNumber = c.Int(nullable: false),
                    FullName = c.String(nullable: false),
                    Semester = c.Int(nullable: false),
                    Email = c.String(),
                    SchoolId = c.Int(nullable: false),
                    WorkshopId = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Schools", t => t.SchoolId, cascadeDelete: true)
                .ForeignKey("dbo.Workshops", t => t.WorkshopId)
                .Index(t => t.ControlNumber, unique: true, name: "UQ_ControlNumber")
                .Index(t => t.SchoolId)
                .Index(t => t.WorkshopId);

            CreateTable(
                "dbo.Schools",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Workshops",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false),
                    Description = c.String(nullable: false),
                    Start = c.DateTime(nullable: false),
                    End = c.DateTime(nullable: false),
                    Duration = c.Int(nullable: false),
                    Instructor = c.String(nullable: false),
                    Company = c.String(nullable: false),
                    Location = c.String(nullable: false),
                    GroupSize = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Requirements",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Description = c.String(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Contacts",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Subject = c.String(nullable: false),
                    Message = c.String(nullable: false),
                    Email = c.String(nullable: false),
                    CreationDate = c.DateTime(nullable: false),
                    Sender = c.String(nullable: false),
                    IsClosed = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Events",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false),
                    Description = c.String(nullable: false),
                    Date = c.DateTime(nullable: false),
                    Duration = c.Int(nullable: false),
                    MinimumTeamSize = c.Int(nullable: false),
                    MaximumTeamSize = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Rules",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Description = c.String(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Organizers",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Roles",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Description = c.String(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Talks",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Speaker = c.String(nullable: false),
                    Company = c.String(nullable: false),
                    Title = c.String(nullable: false),
                    Date = c.DateTime(nullable: false),
                    Duration = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.TeamMembers",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    TeamId = c.Int(nullable: false),
                    StudentId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .ForeignKey("dbo.Teams", t => t.TeamId, cascadeDelete: true)
                .Index(t => t.TeamId)
                .Index(t => t.StudentId, unique: true, name: "UQ_StudentId");

            CreateTable(
                "dbo.Teams",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false),
                    LeaderId = c.Int(nullable: false),
                    EventId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Events", t => t.EventId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.LeaderId, cascadeDelete: false)
                .Index(t => t.LeaderId)
                .Index(t => t.EventId);

            CreateTable(
                "dbo.RequirementWorkshops",
                c => new
                {
                    Requirement_Id = c.Int(nullable: false),
                    Workshop_Id = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.Requirement_Id, t.Workshop_Id })
                .ForeignKey("dbo.Requirements", t => t.Requirement_Id, cascadeDelete: true)
                .ForeignKey("dbo.Workshops", t => t.Workshop_Id, cascadeDelete: true)
                .Index(t => t.Requirement_Id)
                .Index(t => t.Workshop_Id);

            CreateTable(
                "dbo.RuleEvents",
                c => new
                {
                    Rule_Id = c.Int(nullable: false),
                    Event_Id = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.Rule_Id, t.Event_Id })
                .ForeignKey("dbo.Rules", t => t.Rule_Id, cascadeDelete: true)
                .ForeignKey("dbo.Events", t => t.Event_Id, cascadeDelete: true)
                .Index(t => t.Rule_Id)
                .Index(t => t.Event_Id);

            CreateTable(
                "dbo.RoleOrganizers",
                c => new
                {
                    Role_Id = c.Int(nullable: false),
                    Organizer_Id = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.Role_Id, t.Organizer_Id })
                .ForeignKey("dbo.Roles", t => t.Role_Id, cascadeDelete: true)
                .ForeignKey("dbo.Organizers", t => t.Organizer_Id, cascadeDelete: true)
                .Index(t => t.Role_Id)
                .Index(t => t.Organizer_Id);

        }

        public override void Down()
        {
            DropForeignKey("dbo.TeamMembers", "TeamId", "dbo.Teams");
            DropForeignKey("dbo.Teams", "LeaderId", "dbo.Students");
            DropForeignKey("dbo.Teams", "EventId", "dbo.Events");
            DropForeignKey("dbo.TeamMembers", "StudentId", "dbo.Students");
            DropForeignKey("dbo.RoleOrganizers", "Organizer_Id", "dbo.Organizers");
            DropForeignKey("dbo.RoleOrganizers", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.RuleEvents", "Event_Id", "dbo.Events");
            DropForeignKey("dbo.RuleEvents", "Rule_Id", "dbo.Rules");
            DropForeignKey("dbo.Attendances", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Students", "WorkshopId", "dbo.Workshops");
            DropForeignKey("dbo.RequirementWorkshops", "Workshop_Id", "dbo.Workshops");
            DropForeignKey("dbo.RequirementWorkshops", "Requirement_Id", "dbo.Requirements");
            DropForeignKey("dbo.Students", "SchoolId", "dbo.Schools");
            DropIndex("dbo.RoleOrganizers", new[] { "Organizer_Id" });
            DropIndex("dbo.RoleOrganizers", new[] { "Role_Id" });
            DropIndex("dbo.RuleEvents", new[] { "Event_Id" });
            DropIndex("dbo.RuleEvents", new[] { "Rule_Id" });
            DropIndex("dbo.RequirementWorkshops", new[] { "Workshop_Id" });
            DropIndex("dbo.RequirementWorkshops", new[] { "Requirement_Id" });
            DropIndex("dbo.Teams", new[] { "EventId" });
            DropIndex("dbo.Teams", new[] { "LeaderId" });
            DropIndex("dbo.TeamMembers", "UQ_StudentId");
            DropIndex("dbo.TeamMembers", new[] { "TeamId" });
            DropIndex("dbo.Students", new[] { "WorkshopId" });
            DropIndex("dbo.Students", new[] { "SchoolId" });
            DropIndex("dbo.Students", "UQ_ControlNumber");
            DropIndex("dbo.Attendances", new[] { "StudentId" });
            DropTable("dbo.RoleOrganizers");
            DropTable("dbo.RuleEvents");
            DropTable("dbo.RequirementWorkshops");
            DropTable("dbo.Teams");
            DropTable("dbo.TeamMembers");
            DropTable("dbo.Talks");
            DropTable("dbo.Roles");
            DropTable("dbo.Organizers");
            DropTable("dbo.Rules");
            DropTable("dbo.Events");
            DropTable("dbo.Contacts");
            DropTable("dbo.Requirements");
            DropTable("dbo.Workshops");
            DropTable("dbo.Schools");
            DropTable("dbo.Students");
            DropTable("dbo.Attendances");
        }
    }
}
