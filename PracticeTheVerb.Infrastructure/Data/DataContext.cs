using Microsoft.EntityFrameworkCore;
using PracticeTheVerb.Domain.Entities.Italian;
using PracticeTheVerb.Infrastructure.Data.Mappings.Italian;

namespace PracticeTheVerb.Infrastructure.Data;

public class DataContext : DbContext
{
    public DbSet<ItalianVerb> ItalianVerbs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite(@"Data Source=practiceTheVerb.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ItalianVerbsMap());
    }
}