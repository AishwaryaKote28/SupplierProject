using SupplierProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierProject.Infra
{
    public interface ISBilling
    {
        public SBilling GetBillingID(int BillingId);
        public List<SBilling> GetAddress();
        public void AddAddress(SBilling sBilling);
        public void UpdateAddress(SBilling sBilling);
        public void DeleteAdress(int sBillingḍ);
    }
}
