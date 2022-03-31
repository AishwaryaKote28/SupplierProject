using Microsoft.AspNetCore.Mvc;
using SupplierProject.Model;
using SupplierProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SBillingController : Controller
    {
        SBillingServices _repo;
        public SBillingController(SBillingServices repo)
        {
            _repo = repo;
        }
        [HttpGet]
        [Route("GetAddress")]
        public IActionResult GetAddress()
        {
            var sup = _repo.GetAddress();
            return Ok(sup);
        }
        [HttpPost]
        [Route("AddAddress")]
        public IActionResult AddAddress(SBilling Billing)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                _repo.AddAddress(Billing);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpPut]
        [Route("UpdateAddress")]
        public IActionResult UpdateAddress(SBilling Billing)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                _repo.UpdateAddress(Billing);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpDelete]
        [Route("DeleteBilling")]
        public IActionResult DeleteAddress(int Billing)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                _repo.DeleteAddress(Billing);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}



