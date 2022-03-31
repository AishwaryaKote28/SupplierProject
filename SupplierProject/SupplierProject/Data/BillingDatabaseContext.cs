using Microsoft.EntityFrameworkCore;
using SupplierProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierProject.Data
{
    public class BillingDatabaseContext : DbContext
    {
        public BillingDatabaseContext(DbContextOptions<BillingDatabaseContext> options) : base(options)
        {
        }
        public DbSet<SBilling> SBilling { get; set; }
    }
}


