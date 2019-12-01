using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_Assg2.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignupPage : ContentPage
    {
        public SignupPage()
        {
            InitializeComponent();
        }

        public void AddValue(string key, string value)
        {
            Preferences.Set(key, value);
        }

        private void BtnSignUp_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Username.Text) || !string.IsNullOrEmpty(Password.Text))
            {
                AddValue(Username.Text, Password.Text);
                Username.Text = string.Empty;
                Password.Text = string.Empty;
                DisplayAlert("Success", "You are signed in", "OK");
                Navigation.PushAsync(new LoginPage());
            }
            else DisplayAlert("Registration Failed", "Please provide email and password", "OK");

        }
    }
}