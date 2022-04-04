using SupplierProject.Infra;
using SupplierProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierProject.Services
{
    public class SupplierService
    {
        ISupplier _service;
        public SupplierService(ISupplier service)
        {
            _service = service;
        }
        public List<Supplier> GetSupplier()
        {
            return _service.GetSupplier().ToList();
        }
        public Supplier GetSupplierID(int SupplierId)
        {
            return _service.GetSupplierID(SupplierId);
        }
        public void AddSupplier(Supplier supplier)
        {
            _service.AddSupplier(supplier);
        }
        public void UpdateSupplier(Supplier supplier)
        {
            _service.UpdateSupplier(supplier);
        }
        public void DeleteSupplier(int supplier)
        {
            _service.DeleteSupplier(supplier);
        }
    }
}
