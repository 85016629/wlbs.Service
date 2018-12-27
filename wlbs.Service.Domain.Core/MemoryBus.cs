using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace wlbs.Service.Domain.Core
{
    public sealed class MemoryBus
    {
        private static IEventStore<DomainEvent> _eventStore;
        private static IMediator _mediator;
        static void Init(IEventStore<DomainEvent> eventStore, IMediator mediator)
        {
            _eventStore = eventStore;
            _mediator = mediator;
        }

        public static Task RaiseEvent<T>(T @event) where T : DomainEvent
        {
            _eventStore.SaveEvent(@event);

            _mediator.Publish(@event);

            return Task.CompletedTask;
        }

        public static Task<object> SendCommand<T>(T command) where T : ICommand
        {
            return _mediator.Send(command);
        }
    }
}
