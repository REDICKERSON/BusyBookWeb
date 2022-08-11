using Microsoft.EntityFrameworkCore;

namespace BusyBookWeb.Models.Data
{
    public class ApplicationDBContext :DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
