using SupplierProject.Data;
using SupplierProject.Infra;
using SupplierProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierProject.Repo
{
    public class SupplierRepo : ISupplier
    {
        DataBaseContext _context;
        public SupplierRepo(DataBaseContext context)
        {
            _context = context;
        }
        public List<Supplier> GetSupplier()
        {
            var result = (from s in _context.Supplier
                          select new Supplier
                          {
                              SupplierId = s.SupplierId,
                              Name = s.Name,
                          }).ToList();
            return result;
            //return _context.Supplier.ToList();
        }
        public Supplier GetSupplierID(int SupplierId)
        {
            return _context.Supplier.FirstOrDefault(e => e.SupplierId == SupplierId);
        }
        public void AddSupplier(Supplier supplier)
        {
            _context.Add(supplier);
            _context.SaveChanges();
        }
        public void UpdateSupplier(Supplier supplier)
        {
            _context.Update(supplier);
            _context.SaveChanges();
        }
        public void DeleteSupplier(int Supplier)
        {
            var supplier = _context.Supplier.Where(s => s.SupplierId == Supplier).FirstOrDefault();
            if (supplier != null)
            {
                _context.Remove(supplier);
                _context.SaveChanges();
            }
        }
    }
}
