using Microsoft.EntityFrameworkCore;

namespace BullPerks_Challenge;

public class SystemDbContext : DbContext
{
    public SystemDbContext(DbContextOptions<SystemDbContext> options)
    : base(options) 
    {

    }

    public DbSet<UsersModel> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserTableMap());

        base.OnModelCreating(modelBuilder);
    }
}
