using System;
using System.Collections.Generic;
using System.Text;

namespace wlbs.Service.Domain.Core
{
    public interface IEventStore<DomainEvent>
    {
        void SaveEvent<T>(T @event) where T : DomainEvent;
    }
}
