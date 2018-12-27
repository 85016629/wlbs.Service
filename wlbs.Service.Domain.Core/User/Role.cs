using System;
using System.Collections.Generic;
using System.Text;

namespace wlbs.Service.Domain.Core
{
    public sealed class Role : AggregateRoot<Guid>
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDesc { get; set; }
    }
}
