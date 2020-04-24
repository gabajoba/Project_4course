using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.StartPageFiles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
           // Title = "TESTING";
            
        }
        
        private async void RegButton_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new RegPage());
        }
        private async void AuthButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AuthPage());
        }

        private  void SkipButton_Clicked(object sender, EventArgs e)
        {
            // await Navigation.PushAsync(new AppShell());
            // var page = new NavigationPage(new AppShell());
            var page = new AppShell();
                 
             (Application.Current.MainPage) = page;
        }
    }
}