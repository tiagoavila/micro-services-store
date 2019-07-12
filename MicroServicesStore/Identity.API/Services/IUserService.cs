using Identity.API.ViewModels;

namespace Identity.API.Services
{
    public interface IUserService
    {
        SecurityTokenViewModel Authenticate(LoginViewModel loginViewModel);
    }
}
