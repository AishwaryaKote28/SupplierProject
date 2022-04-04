using Microsoft.AspNetCore.Mvc;
using SupplierProject.Model;
using SupplierProject.Services;
using System;

namespace SupplierProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        ProductService _repo;
        public ProductController(ProductService repo)
        {
            _repo = repo;
        }
        [HttpGet]
        [Route("GetProduct")]
        public IActionResult GetProduct()
        {
            var product = _repo.GetProduct();
            return Ok(product);
        }
        [HttpPost]
        [Route("AddProduct")]
        public IActionResult AddProduct(Product Product)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                _repo.AddProduct(Product);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpPut]
        [Route("UpdateProduct")]
        public IActionResult UpdateProduct(Product Product)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                _repo.UpdateProduct(Product);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpDelete]
        [Route("DeleteProduct")]
        public IActionResult DeleteProduct(int Product)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                _repo.DeleteProduct(Product);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}



