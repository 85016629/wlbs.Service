using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace wlbs.Service.Domain.Core
{
    public interface ICommandHandler<in T> where T : ICommand
    {
        Task HandleAsync(T command);
    }
}
