using Microsoft.EntityFrameworkCore;
using ParcelManagementSystemMVC.DBCOnnect;
using ParcelManagementSystemMVC.DBContext;
using ParcelManagementSystemMVC.DBContext;

namespace ParcelManagementSystemMVC.DBContext
{
    public class EmplDbContext : DbContext
    {
        public EmplDbContext(DbContextOptions<EmplDbContext> options) : base(options)
        {
        }
        public DbSet<EmployDB> EmployDB { get; set; }

    }
}
