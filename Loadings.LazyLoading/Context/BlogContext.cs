// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;

public class BlogContext : DbContext
{
    public DbSet<Article> Articles { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Address> Addresses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-ATVPBPS;Database=BlogDb;Integrated Security=true;Encrypt=False");
    
        optionsBuilder.UseLazyLoadingProxies();
    }
}

