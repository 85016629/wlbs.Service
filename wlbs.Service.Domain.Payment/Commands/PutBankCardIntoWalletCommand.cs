using System;
using System.Collections.Generic;
using System.Text;
using wlbs.Service.Domain.Core;

namespace wlbs.Service.Domain.Payment.Commands
{
    public class PutBankCardIntoWalletCommand : ICommand
    {

        public string BankCardNo
        {
            get => default(int);
            set
            {
            }
        }

        public string BankCardNm
        {
            get => default(int);
            set
            {
            }
        }

        public string IdCardNo
        {
            get => default(int);
            set
            {
            }
        }

        public string Mobile
        {
            get => default(int);
            set
            {
            }
        }

        public string Owner
        {
            get => default(int);
            set
            {
            }
        }
    }
}
