using TechChallenge.Model;

namespace TechChallenge.App.Service
{
    public class LoginDataService : ILoginDataService
    {
        #region Method

        public LoginDetail GetDefaultLoginCredentials()
        {
            return new LoginDetail()
            {
                UserName = "taskmanager",
                UserPassword = "task@123"
            };
        }

        #endregion
    }
}
