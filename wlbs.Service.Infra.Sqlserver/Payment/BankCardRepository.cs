using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wlbs.Service.Domain.Payment;
using wlbs.Service.Domain.Payment.Repositories;

namespace wlbs.Service.Infra.Sqlserver.Payment
{
    public class BankCardRepository : BaseRepository<BankCard, Guid>, IBankCardRepository
    {
        private static readonly WriteDbContext WriteDb = new WriteDbContext();
        public ICollection<BankCard> QueryBankCards(int pageIndex, int pageSize)
        {
            var result = WriteDb.BankCards
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            return result;
        }
    }
}
