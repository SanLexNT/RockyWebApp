using Microsoft.EntityFrameworkCore;
using RockyWebApp.Models;

namespace RockyWebApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Category { get; set; }
    }
}
