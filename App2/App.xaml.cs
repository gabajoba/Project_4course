using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            var page = new NavigationPage(new App2.StartPageFiles.StartPage());
            page.BackgroundColor = Color.FromHex("#FCB259");
            page.BarBackgroundColor = Color.FromHex("#ff8256");
            
            page.BarTextColor = Color.Black;
           
            MainPage = page;
            
        }
       
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
