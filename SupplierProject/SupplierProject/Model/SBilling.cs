using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierProject.Model
{
    public class SBilling
    {
        [Key]
        public int BillingId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int Supplierid { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
