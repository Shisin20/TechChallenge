using System.Windows;
using System.Windows.Controls;

namespace TechChallenge.App.View
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Page
    {
        public LoginView()
        {
            InitializeComponent();
        }

        //assinin
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ApplicationHelper.NavigationService = this.NavigationService;
        }
    }
}
