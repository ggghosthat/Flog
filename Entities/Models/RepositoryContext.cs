using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace Entities.Models;
public class RepositoryContext : IdentityDbContext<User>
{
	public RepositoryContext(DbContextOptions options) 
		: base(options)
	{
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
        base.OnModelCreating(modelBuilder);
	}

	public DbSet<User> Users {get; set;}
	public DbSet<Flog> Flogs {get; set;}
}