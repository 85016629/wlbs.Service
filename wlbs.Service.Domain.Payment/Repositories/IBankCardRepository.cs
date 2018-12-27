using System;
using System.Collections.Generic;
using System.Text;
using wlbs.Service.Domain.Core;

namespace wlbs.Service.Domain.Payment.Repositories
{
    public interface IBankCardRepository : IRepository<BankCard, Guid>
    {
        ICollection<BankCard> QueryBankCards(int pageIndex, int pageSize);
    }
}
