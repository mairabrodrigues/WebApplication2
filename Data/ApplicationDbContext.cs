using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NetFlex2.Models;

namespace WebApplication2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<NetFlex2.Models.Serie> Serie { get; set; } = default!;
        public DbSet<NetFlex2.Models.Client> Client { get; set; } = default!;
    }
}