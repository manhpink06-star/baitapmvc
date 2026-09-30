using baitapmvc.Models;
using Microsoft.EntityFrameworkCore;

namespace baitapmvc.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<DayInfo> NgayTrongTuan { get; set; }
    }
}