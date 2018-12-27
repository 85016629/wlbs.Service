using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace wlbs.Service.Domain.Core
{
    public interface IEventHandler<in T> where T : INotification
    {
        Task HandleAsync(T @event);
    }
}
