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
        ISupplier _sservice;
        public SupplierService(ISupplier service)
        {
            _sservice = service;
        }
        public List<Supplier> GetSupplier()
        {
            return _sservice.GetSupplier().ToList();
        }
        public Supplier GetSupplierID(int SupplierId)
        {
            return _sservice.GetSupplierID(SupplierId);
        }
        public void AddSupplier(Supplier supplier)
        {
            _sservice.AddSupplier(supplier);
        }
        public void UpdateSupplier(Supplier supplier)
        {
            _sservice.UpdateSupplier(supplier);
        }
        public void DeleteSupplier(int supplier)
        {
            _sservice.DeleteSupplier(supplier);
        }
    }
}
