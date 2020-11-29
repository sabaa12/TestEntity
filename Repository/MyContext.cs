using Domain;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class MyContext : DbContext
    {

        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Book>().Property(x => x.Title).HasMaxLength(100).IsRequired();

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\sqlexpress;Initial Catalog=TestEntity;Integrated Security=True");
        }
    }
}
