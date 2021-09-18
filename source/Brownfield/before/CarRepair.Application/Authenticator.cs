using CarRepair.Application.Interfaces;
using CarRepair.Core.Entities;

namespace CarRepair.Application
{
    public class Authenticator : IAuthenticator
    {
        public bool Login(LogInInfo logInInfo)
        {
            // dummy implementation
            return true;
        }

        public bool Logout()
        {
            // dummy implementation
            return true;
        }
    }
}