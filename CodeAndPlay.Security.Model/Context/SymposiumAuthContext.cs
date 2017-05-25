using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace CodeAndPlay.Security.Model.Context
{
    public class SymposiumAuthContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }

        public SymposiumAuthContext()
            : base("SymposiumAuthContext")
        {

        }
    }
}