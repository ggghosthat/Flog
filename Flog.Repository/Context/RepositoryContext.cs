using Flog.Entities;

using Microsoft.EntityFrameworkCore;

namespace Flog.Repository.Context;

public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions options) : base(options)
    {}

    public DbSet<User> Users { get; set; }
    
    public DbSet<Post> Posts { get; set; }
    
    public DbSet<Tag> Tags { get; set; }
}