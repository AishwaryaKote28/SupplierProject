using SupplierProject.Infra;
using SupplierProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierProject.Services
{
    public class SBillingServices
    {
        ISBilling _service;
        public SBillingServices(ISBilling service)
        {
            _service = service;
        }
        public List<SBilling> GetAddress()
        {
            return _service.GetAddress().ToList();
        }
        public SBilling GetBillingID(int BillingId)
        {
            return _service.GetBillingID(BillingId);
        }
        public void AddAddress(SBilling sBilling)
        {
            _service.AddAddress(sBilling);
        }
        public void UpdateAddress(SBilling sBilling)
        {
            _service.UpdateAddress(sBilling);
        }
        public void DeleteAddress(int sBilling)
        {
            _service.DeleteAdress(sBilling);
        }
    }
}



