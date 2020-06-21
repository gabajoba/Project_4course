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
            page.BackgroundColor = Color.White;
            page.BarBackgroundColor = Color.Orange;
           
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
