using Microsoft.EntityFrameworkCore;
using SupplierProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierProject.Data
{
    public class ProductDataBaseContext : DbContext
    {
        public ProductDataBaseContext(DbContextOptions<ProductDataBaseContext> options) : base(options)
        {
        }
        public DbSet<Product> Product { get; set; }
    }
}
