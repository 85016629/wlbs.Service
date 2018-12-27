using System;
using System.Collections.Generic;
using System.Text;
using wlbs.Service.Domain.Core;

namespace wlbs.Service.Domain.Payment
{
    public class Settlement : AggregateRoot<Guid>
    {
        /// <summary>
        /// 结算Id。
        /// </summary>
        public string SettlementId { get; set; }
    }
}
