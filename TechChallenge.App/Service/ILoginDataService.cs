using TechChallenge.Model;

namespace TechChallenge.App.Service
{
    public interface ILoginDataService
    {
        LoginDetail GetDefaultLoginCredentials();
    }
}
