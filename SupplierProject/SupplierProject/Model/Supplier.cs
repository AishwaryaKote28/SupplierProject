using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierProject.Model
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }
        public string Name { get; set; }
        public virtual SBilling SBilling { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }
}
