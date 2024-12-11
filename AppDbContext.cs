using Microsoft.EntityFrameworkCore;
using Exercice.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<User> User { get; set; }
    public DbSet<UserProfile> UserProfile { get; set; }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }

    // protected override void OnModelCreating(ModelBuilder modelBuilder) {
    //     // Configuration de la relation 1:1 entre User et UserProfile
    //     modelBuilder.Entity<User>()
    //         .HasOne(u => u.UserProfile)
    //         .WithOne(up => up.User)
    //         .HasForeignKey<UserProfile>(up => up.UserId);

    //     // Configuration de la relation 1:N entre Category et Product
    //     modelBuilder.Entity<Category>()
    //         .HasMany(c => c.Products)
    //         .WithOne(p => p.Category)
    //         .HasForeignKey(p => p.CategoryId);
    // }

}
