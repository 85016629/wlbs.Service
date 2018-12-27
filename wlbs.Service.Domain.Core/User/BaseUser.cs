using System;
using System.Collections.Generic;
using System.Text;

namespace wlbs.Service.Domain.Core
{
    public abstract class BaseUser : AggregateRoot<Guid>
    {
        public string UserLoginId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Mobile { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
