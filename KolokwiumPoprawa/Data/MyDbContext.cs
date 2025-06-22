using KolokwiumPoprawa.Models;
using Microsoft.EntityFrameworkCore;

namespace KolokwiumPoprawa.Data;

public class MyDbContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserBookFavorite> UserBookFavorites { get; set; }
    public DbSet<Loan> Loans { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserBookFavorite>()
            .HasKey(e => new { e.Book_ID, e.User_ID });
        modelBuilder.Entity<UserBookFavorite>()
            .HasOne(e => e.Book)
            .WithMany(s => s.UserBookFavorites)
            .HasForeignKey(e => e.Book_ID);
        modelBuilder.Entity<UserBookFavorite>()
            .HasOne(e => e.User)
            .WithMany(c => c.UserBookFavorites)
            .HasForeignKey(e => e.User_ID);
        modelBuilder.Entity<Loan>()
            .HasKey(e => new { e.Book_ID, e.User_ID });
        modelBuilder.Entity<Loan>()
            .HasOne(e => e.Book)
            .WithMany(s => s.Loans)
            .HasForeignKey(e => e.Book_ID);
        modelBuilder.Entity<Loan>()
            .HasOne(e => e.User)
            .WithMany(c => c.Loans)
            .HasForeignKey(e => e.User_ID);
            
            
    }
    public MyDbContext(DbContextOptions options) : base(options)
    {
    }
}
