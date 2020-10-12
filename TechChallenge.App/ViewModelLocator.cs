using TechChallenge.App.Service;
using TechChallenge.App.ViewModel;
using TechChallenge.DAL;

namespace TechChallenge.App
{
    public class ViewModelLocator
    {
        private static ITaskDataService taskDataService = new TaskDataService(new TaskRepository());

        private static ILoginDataService loginDataService = new LoginDataService();

        private static TaskOverviewViewModel overviewViewModel = new TaskOverviewViewModel(taskDataService);

        private static LoginViewModel loginViewModel = new LoginViewModel(loginDataService);

        public static TaskOverviewViewModel TaskOverviewViewModel
        {
            get
            {
                return overviewViewModel;
            }
        }

        public static LoginViewModel LoginViewModel
        {
            get
            {
                return loginViewModel;
            }
        }
    }
}
