using Microsoft.EntityFrameworkCore;
using PracticeTheVerb.Domain.Entities.Italian;
using PracticeTheVerb.Infrastructure.Data.Mappings.Italian;

namespace PracticeTheVerb.Infrastructure.Data;

public class DataContext : DbContext
{
	public DbSet<ItalianVerb> ItalianVerbs { get; set; }
	protected override void OnConfiguring(DbContextOptionsBuilder options)
	{
		options.UseMySQL("server=localhost;database=RaphaelCordon;user=root;password=root");
	}
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.ApplyConfiguration(new ItalianVerbsMap());
	}
}
