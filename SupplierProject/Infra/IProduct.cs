using SupplierProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierProject.Infra
{
    public interface IProduct
    {
        public List<Product> GetProduct();
        public Product GetProductID(int ProductId);
        public void AddProduct(Product Product);
        public void UpdateProduct(Product Product);
        public void DeleteProduct(int Product);
    }
}
