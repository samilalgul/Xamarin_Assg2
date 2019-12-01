using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin_Assg2.Pages;

namespace Xamarin_Assg2.ViewModels
{
    class LoginViewModel : INotifyPropertyChanged
    {

        public ICommand NavigateToRegisterPage
        {
            get
            {
                return new Command(async () => {
                    await App.Current.MainPage.Navigation.PushModalAsync(new SignupPage(), true);
                });
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
