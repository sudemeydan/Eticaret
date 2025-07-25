using Eticaret.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Eticaret.Data
{
    public class DatabaseContext :DbContext
    {
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppUser> Brands { get; set; }
        public DbSet<AppUser> Categories { get; set; }
        public DbSet<AppUser> Contacts { get; set; }
        public DbSet<AppUser> News { get; set; }
        public DbSet<AppUser> Products { get; set; }
        public DbSet<AppUser> Sliders { get; set; }

    }
}
