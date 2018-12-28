using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using wlbs.Service.Domain.Core;
using wlbs.Service.Domain.Payment.Commands;

namespace wlbs.Service.Domain.Payment.CommandHandlers
{
    public class BankCardCommandHandler : 
        ICommandHandler<PutBankCardIntoWalletCommand>
    {
        public Task HandleAsync(PutBankCardIntoWalletCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
