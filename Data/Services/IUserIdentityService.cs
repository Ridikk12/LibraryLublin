using Data.Entities;

namespace Data.Services
{
    public interface IUserIdentityService
    {

        void LogIn(string userEmail, string password);
        void LogOut();
        void Register(User user);

    }
}