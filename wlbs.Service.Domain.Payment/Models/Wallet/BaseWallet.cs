using System;
using System.Collections.Generic;
using System.Text;
using wlbs.Service.Domain.Core;

namespace wlbs.Service.Domain.Payment
{
    public class BaseWallet : AggregateRoot<int>
    {
        public string OwnerName { get; set; }
        public string WalletNo { get; set; }
    }
}
