using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ReProject.Domain.Adverts;
using ReProject.Domain.Categories;
using ReProject.Domain.Users;

namespace ReProject.Data.EfCore;

public class ReProjectDbContext : DbContext
{
    
    public ReProjectDbContext(DbContextOptions <ReProjectDbContext> options) : base(options)
        //dinamik olarak gönderilen dbcontext
    {
    }

    protected ReProjectDbContext()
        //boş olan ctor
    {
    }

    //dbsetler gelecek
    public DbSet<Category> Categories { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Attribute> Attributes { get; set; }
    public DbSet<Advert> Adverts { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
        //burada mapping islemleri yapilacak(vt'na giden yol)
    {
        modelBuilder.Entity<Category>(b =>
        {
            b.ToTable("Categories");
            b.HasKey(k => k.Id);
            b.Property(p => p.Name).IsRequired();
            
        }); 
    }

   

}

