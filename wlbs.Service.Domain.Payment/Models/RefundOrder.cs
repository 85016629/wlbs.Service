using System;
using System.Collections.Generic;
using System.Text;
using wlbs.Service.Domain.Core;

namespace wlbs.Service.Domain.Payment
{
    public class RefundOrder : AggregateRoot<Guid>
    {
        public decimal RefundAmount { get; set; }
        public string TransactionFlowId { get; set; }
        public TransactionFlow TransactionFlow { get; set; }
    }
}
