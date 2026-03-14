using Microsoft.EntityFrameworkCore;
using PersonalWebsiteBE.Models;

namespace PersonalWebsiteBE.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Message> Messages { get; set; }
    }
}