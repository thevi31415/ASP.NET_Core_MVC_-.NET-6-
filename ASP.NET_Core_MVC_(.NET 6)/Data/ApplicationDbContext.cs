using ASP.NET_Core_MVC__.NET_6_.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Core_MVC__.NET_6_.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        
            
        
        }
        public DbSet<Category> Categories { get; set; }
        
            
        
    }
}
