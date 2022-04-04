using SupplierProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierProject.Infra
{
    public interface ISupplier
     {
        public List<Supplier> GetSupplier();
        public Supplier GetSupplierID(int SupplierId);
        public void AddSupplier(Supplier Supplier);
        public void UpdateSupplier(Supplier Supplier);
        public void DeleteSupplier(int Supplier);
     }
}
