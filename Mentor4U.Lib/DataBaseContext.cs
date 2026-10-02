using Microsoft.EntityFrameworkCore;

namespace Mentor4U.Lib;

public sealed class DataBaseContext : DbContext
{
    public DbSet<Mentor> Mentors { get; set; }

    public DataBaseContext(DbContextOptions<DataBaseContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }
}