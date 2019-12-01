using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_Assg2.Models;
using Xamarin_Assg2.ViewModels;

namespace Xamarin_Assg2.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tab2_PersonsPage : ContentPage
    {
        public Tab2_PersonsPage()
        {
            InitializeComponent();
            BindingContext = new PersonViewModel();

        }

        async void Call_Tapped(object Sender, EventArgs e)
        {


        }

        public async Task Call(string number)
        {
            try
            {
                
                PhoneDialer.Open(number);
            }

            catch (FeatureNotSupportedException)
            {
                // Phone Dialer is not supported on this device. 
            }
            catch (Exception)
            {
                // Other error has occurred.  
            }
        }

        private async void CallBtnClicked(object Sender, EventArgs e)
        {
            Button button = (Button)Sender;
            string GSM = button.CommandParameter.ToString();

            var ans = await DisplayAlert("Are you sure?", "Would you like to call this number " + GSM, "Yes", "No");
            if (ans == true)
            {
                await Call(GSM);
            }
            else
            {
                await DisplayAlert("Disabled", "", "OK");
            }
        }
    }
}