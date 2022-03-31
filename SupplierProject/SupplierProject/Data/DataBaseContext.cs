using Microsoft.EntityFrameworkCore;
using SupplierProject.Model;

namespace SupplierProject.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }
        public DbSet<Supplier> Supplier { get; set; }
    }
}
