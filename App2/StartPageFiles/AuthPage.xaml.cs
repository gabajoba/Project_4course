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
    public partial class AuthPage : ContentPage
    {
        public AuthPage()
        {
            
            InitializeComponent();
            //((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex("#ff8256");
            ((NavigationPage)Application.Current.MainPage).Title = "Авторизация";
        }
        protected override bool OnBackButtonPressed()
        {
            Navigation.RemovePage(Navigation.NavigationStack[Navigation.NavigationStack.Count - 1]);
            return false;
            //return base.OnBackButtonPressed();
        }


    }
}