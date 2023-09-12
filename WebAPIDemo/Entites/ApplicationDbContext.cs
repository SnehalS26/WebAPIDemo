using Microsoft.EntityFrameworkCore;
namespace WebAPIDemo.Entites
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}
