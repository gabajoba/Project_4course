using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsPage : ContentPage
    {
        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public ContactsPage()
        {
            InitializeComponent();
            BindingContext = this;
        }
        void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {

            if (sender == vk)
            {
                Launcher.OpenAsync("https://gabajoba.ru/");
            } else
            if (sender == instagram)
            {
                Launcher.OpenAsync("https://www.instagram.com/gabajoba_/");
            } else
            if (sender == youtube)
            {
                Launcher.OpenAsync("https://www.youtube.com/user/1Cu6up9lk/");
            } else
            if (sender == twitter)
            {
                Launcher.OpenAsync("https://www.guillemrecolons.com/wp-content/uploads/2011/02/twitter_dead.jpg");
            }
        }
    }
}