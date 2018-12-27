using System;
using System.Collections.Generic;
using System.Text;

namespace wlbs.Service.Domain.Core
{
    public class DomainEvent : AggregateRoot<Guid>, IEvent
    {

    }
}
