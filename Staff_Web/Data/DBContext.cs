using Microsoft.EntityFrameworkCore;
using Staff_Web.Models;

namespace Staff_Web.Data
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; } = default!;
    }
}
