using Microsoft.EntityFrameworkCore;
using ReloadingAppWebApi.Models;

namespace ReloadingAppWebApi.Data;

public class ReloadDbContext : DbContext
{
    public ReloadDbContext(DbContextOptions<ReloadDbContext> options) : base(options)
    {
    }
    
    public DbSet<Bullet> Bullets { get; set; }
}