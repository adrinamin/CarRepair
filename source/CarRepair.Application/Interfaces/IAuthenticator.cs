using CarRepair.Core.Entities;

namespace CarRepair.Application.Interfaces
{
    public interface IAuthenticator
    {
        bool Login(LogInInfo logInInfo);
        bool Logout();
    }
}