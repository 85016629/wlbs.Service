using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace wlbs.Service.Domain.Core
{
    public interface IEvent : IMessage, INotification
    {

    }
}
