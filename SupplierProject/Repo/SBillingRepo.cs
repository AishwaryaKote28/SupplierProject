using SupplierProject.Data;
using SupplierProject.Infra;
using SupplierProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierProject.Repo
{
    public class SBillingRepo : ISBilling
    {
        BillingDatabaseContext _context;
        public SBillingRepo(BillingDatabaseContext context)
        {
            _context = context;
        }
        public List<SBilling> GetAddress()
        {
            return _context.SBilling.ToList();
        }
        public SBilling GetBillingID(int BillingId)
        {
            return _context.SBilling.FirstOrDefault(e => e.BillingId == BillingId);
        }
        public void AddAddress(SBilling sBilling)
        {
            _context.Add(sBilling);
            _context.Add(sBilling);
            _context.SaveChanges();
        }
        public void UpdateAddress(SBilling sBilling)
        {
            _context.Update(sBilling);
            _context.SaveChanges();
        }
        public void DeleteAdress(int sBilling)
        {
            var billing = _context.SBilling.Where(s => s.BillingId == sBilling).FirstOrDefault();
            if (billing != null)
            {
                _context.Remove(billing);
                _context.SaveChanges();
            }
            //else
            //{
                
            //}
        }
    }
}


