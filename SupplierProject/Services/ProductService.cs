using SupplierProject.Infra;
using SupplierProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierProject.Services
{
    public class ProductService
    {
        IProduct _service;
        public ProductService(IProduct service)
        {
            _service = service;
        }
        public List<Product> GetProduct()
        {
            return _service.GetProduct().ToList();
            //List<Supplier> supplier = _sservice.GetSupplier();
            // return supplier.ToList();
        }
        public Product GetProductID(int ProductId)
        {
            return _service.GetProductID(ProductId);
        }
        public void AddProduct(Product Product)
        {
            _service.AddProduct(Product);
        }
        public void UpdateProduct(Product Product)
        {
            _service.UpdateProduct(Product);
        }
        public void DeleteProduct(int Product)
        {
            _service.DeleteProduct(Product);
        }
    }
}
