using System;
using System.Collections.Generic;
using System.Text;

namespace wlbs.Service.Domain.AuthenticationCore
{
    public interface IAuthenticationCoreService
    {
        AppUser Login(string userLoginId, string password);
        void Logout(string userLoginId);
    }
}
