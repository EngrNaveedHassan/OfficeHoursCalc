using Microsoft.EntityFrameworkCore;
using OfficeHoursCalc.Entities;

namespace OfficeHoursCalc.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected AppDbContext()
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Entry> Entries { get; set; }
    }
}
