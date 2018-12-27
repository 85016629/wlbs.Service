using System;
using System.Collections.Generic;
using System.Text;

namespace wlbs.Service.Domain.Payment
{
    public interface IThirdPartyPaymentService
    {
        string RequestBankCardPay();
        string ConfirmBankCardPay();
        string Alipay();
        string WechatPay();
        string Refund();
        string QueryBankCardInfo();
        string BindBankCard();
        string ConfirmBindBankCard();
    }
}
