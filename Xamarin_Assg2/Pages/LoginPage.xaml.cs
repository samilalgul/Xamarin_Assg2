using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_Assg2.ViewModels;

namespace Xamarin_Assg2.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
        }

        private void BtnLog_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usr.Text) || string.IsNullOrEmpty(password.Text))
                DisplayAlert("Empty Values", "Please enter Email and Password", "OK");
            else
            {
                string value = Preferences.Get(usr.Text, "");
                if (password.Text == value)
                {
                    DisplayAlert("Login Success", "", "Ok");
                    //Navigate to Wellcom page after successfully login  
                    Navigation.PushAsync(new MainTappedPage());
                }
                else
                    DisplayAlert("Login Fail", "Please enter correct Email and Password", "OK");
            }
        }

        private void OnTapSignUpLabel(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignupPage());

        }
    }
}