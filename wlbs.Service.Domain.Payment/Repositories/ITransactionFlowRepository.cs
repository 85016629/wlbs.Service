using System;
using System.Collections.Generic;
using System.Text;
using wlbs.Service.Domain.Core;

namespace wlbs.Service.Domain.Payment
{
    public interface ITransactionFlowRepository : IRepository<TransactionFlow, string>
    {

    }
}
