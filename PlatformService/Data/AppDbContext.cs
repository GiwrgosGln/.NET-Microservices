using Microsoft.EntityFrameworkCore;
using PlatformService.Models;

namespace PlatformService.Data 
{
    public class AppDbContext : AppDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }
    }

    public DbSet<PlatformService> Platforms { get; set; }
}