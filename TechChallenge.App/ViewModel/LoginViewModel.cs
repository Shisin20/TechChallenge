using System;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Navigation;
using TechChallenge.Model;
using TechChallenge.App.Service;
using TechChallenge.App.Utility;
using TechChallenge.App.View;

namespace TechChallenge.App.ViewModel
{
	//LoginViewModel class as ViewModel for Login implementing INotifyPropertyChanged  
	public class LoginViewModel : INotifyPropertyChanged
	{
		#region Properties
		private string _userName;

		public string UserName
		{
			get { return _userName; }
			set 
			{ 
				_userName = value;
				RaisePropertyChanged("UserName");
			}
		}


		public string Password { get; set; }

		private string _loginError;

		//shows error while login
		public string LoginError
		{
			get { return _loginError; }
			set
			{
				_loginError = value;
				RaisePropertyChanged("LoginError");
			}
		}


		private ILoginDataService loginDataService;

		public event PropertyChangedEventHandler PropertyChanged;


		#endregion

		#region Commands

		private CustomCommand<PasswordBox> _loginCommand;


		public CustomCommand<PasswordBox> LoginCommand
		{
			get { return _loginCommand ?? (_loginCommand = new CustomCommand<PasswordBox>(Login, CanLogin)); }
		}

		#endregion

		#region Constructor

		public LoginViewModel(ILoginDataService loginDataService)
		{
			this.loginDataService = loginDataService;
		}

		#endregion

		#region Methods

		private bool CanLogin(PasswordBox passwordObj)
		{
			return !string.IsNullOrEmpty(UserName);
		}

		private void Login(PasswordBox passwordObj)
		{
			LoginDetail loginData = loginDataService.GetDefaultLoginCredentials();
			if (loginData.UserName.Equals(UserName) && loginData.UserPassword.Equals(passwordObj.Password)){
				TaskOverview overView = new TaskOverview();
				ApplicationHelper.NavigationService.Navigate(new Uri("View/TaskOverview.xaml", UriKind.RelativeOrAbsolute));
			}
			else
				LoginError = "Entered credentials are invalid.";
		}

		private void RaisePropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}

		#endregion
	}
}
