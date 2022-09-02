using DigitalStudentCard.Core.Services.Contracts.Data;
using DigitalStudentCard.Core.Services.Contracts.General;
using DigitalStudentCard.Core.Views;
using System;
using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DigitalStudentCard.Core.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IAlertService _alertService;

        private string _userName;
        private string _password;

        public LoginViewModel(IAuthenticationService authenticationService, IAlertService alertService)
            : base()
        {
            _authenticationService = authenticationService;
            _alertService = alertService;
        }

        public ICommand LoginCommand => new Command(OnLogin);

        // public ICommand RegisterCommand => new Command(OnRegister);

        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        private async void OnLogin()
        {
            try
            {
                IsBusy = true;
                if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                {
                    var authenticationResponse = await _authenticationService.Authenticate(UserName, Password);

                    if (authenticationResponse.IsAuthenticated)
                    {
                        // we store the Id to know if the user is already logged in to the application
                        Preferences.Set("UserId", authenticationResponse.User.Id);
                        Preferences.Set("UserName", authenticationResponse.User.FirstName);

                        IsBusy = false;
                        await Shell.Current.GoToAsync($"{nameof(AboutPage)}");
                    } else
                    {
                        await _alertService.ShowAsync("This username/password combination isn't known");
                    }
                }
                else
                {
                    await _alertService.ShowAsync("No internet connection");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        /*
        private void OnRegister()
        {
            _navigationService.NavigateToAsync<RegistrationViewModel>();
        }
        */
    }
}
