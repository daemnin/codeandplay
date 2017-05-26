using CodeAndPlay.Model.Entities;
using System.Data.Entity;

namespace CodeAndPlay.Model.Context
{
    public class SymposiumContext : DbContext
    {
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<Requirement> Requirements { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Rule> Rules { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Talk> Talks { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Workshop> Workshops { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }

        public SymposiumContext()
            : base("SymposiumContext")
        {

        }
    }
}
