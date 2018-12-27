using System;
using wlbs.Service.Domain.Core;

namespace wlbs.Service.Domain.Payment
{
    public class DealResult : AggregateRoot<Guid>
    {
        public ResultFlag ResultFlag { get; set; }
        public string ResultMsg { get; set; }
        public int OprId { get; set; }
        public string OprName { get; set; }
        public DateTime OprTime { get; set; }
    }


    public enum ResultFlag : byte
    {
        Agree = 0,
        Refurse = 1
    }
}
