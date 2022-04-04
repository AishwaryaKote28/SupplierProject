using SupplierProject.Data;
using SupplierProject.Infra;
using SupplierProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierProject.Repo
{
    public class ProductRepo : IProduct
    {
        ProductDataBaseContext _context;
        public ProductRepo(ProductDataBaseContext context)
        {
            _context = context;
        }
        public List<Product> GetProduct()
        {
            return _context.Product.ToList();
        }
        public Product GetProductID(int ProductId)
        {
            return _context.Product.FirstOrDefault(e => e.ProductId == ProductId);
        }
        public void AddProduct(Product Product)
        {
            _context.Add(Product);
            _context.SaveChanges();
        }
        public void UpdateProduct(Product Product)
        {
            _context.Update(Product);
            _context.SaveChanges();
        }
        public void DeleteProduct(int Product)
        {
            var product = _context.Product.Where(s => s.ProductId == Product).FirstOrDefault();
            if (product != null)
            {
                _context.Remove(product);
                _context.SaveChanges();
            }
        }
    }
}

