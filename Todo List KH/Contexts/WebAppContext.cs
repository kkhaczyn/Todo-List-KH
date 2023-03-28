using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Todo_List_KH.AppContext
{
    public class WebAppContext : DbContext
    {
        public DbSet<Models.Task> Tasks { get; set; }

        public WebAppContext(DbContextOptions<WebAppContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
