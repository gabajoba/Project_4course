using App2.Data.User;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        public static string Email = null;

        public ProfilePage()
        {
            InitializeComponent();
            BindingContext = this;

            if (UserInfo.Email != null)
            {
                Email = UserInfo.Email.ToString();
                authButton.IsVisible = false;
                regButton.IsVisible = false;
                _emailLabel.Text = "Вы вошли как: " + UserInfo.Email.ToString();
            }
            else
            {
                _test2.IsVisible = false;               
                _emailLabel.IsVisible = false;
            }
        }

        private async void RegButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"regdetails");
        }

        private async void AuthButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"authdetails");
        }      
    }
}