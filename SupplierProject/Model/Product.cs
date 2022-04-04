using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierProject.Model
{
    public class Product
    {
        [Key]
        public double ProductId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
