using APP_Using__Automapper.Models;
using Microsoft.EntityFrameworkCore;

namespace APP_Using__Automapper.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }
        
        public DbSet<Book> Books { get; set; }
    }
}
