using AuthSystem.Areas.Identity.Data;
using AuthSystem.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace AuthSystem.Data;

public class AuthDBContext : IdentityDbContext<ApplicationUser>
{
    public AuthDBContext(DbContextOptions<AuthDBContext> options)
        : base(options)
    {
    }
    //set the database in the dbcontext class
    //https://www.youtube.com/watch?v=wzaoQiS_9dI&t=174s
    public DbSet<Item> Items { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        builder.Entity<Item>(entity =>
        //define the requirements of item entity
        //https://stackoverflow.com/questions/26425686/how-to-write-a-dbcontext-class
        {
            entity.HasKey(e => e.ItemID);
            entity.Property(e => e.ItemID).ValueGeneratedOnAdd();
            entity.Property(e => e.ItemName).IsRequired();
            entity.Property(e => e.ItemCategory).IsRequired();
            entity.Property(e => e.ItemPrice).IsRequired().HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ItemAvailability).IsRequired();

        });

        builder.Entity<Transaction>(entity =>
        {
            //define requirements for the transactions entity
            entity.HasKey(e => e.TransactionID);
            entity.Property(e => e.TransactionID).ValueGeneratedOnAdd();
            entity.Property(e => e.OrderDate).IsRequired();
            entity.Property(e => e.TotalAmount).IsRequired().HasColumnType("decimal(18, 2)");



        });

    }
}