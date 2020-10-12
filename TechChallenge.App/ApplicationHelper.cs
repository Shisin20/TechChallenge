using System.Windows.Navigation;

namespace TechChallenge.App
{
    //NavigationContext static helper class 
    public static class ApplicationHelper
    {
        private static NavigationService _navigationService;

        public static NavigationService NavigationService
        {
            set
            {
                _navigationService = value;
            }
            get
            {
                return _navigationService;
            }

        }
    }
}
