using Microsoft.EntityFrameworkCore;
using webApi.Model.Entity;

namespace webApi.Data
{
    public class AppDbConst : DbContext
    {
        public AppDbConst(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
