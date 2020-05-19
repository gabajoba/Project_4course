using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
     
            // watch the monkey go from color to black&white!
            
           if(sender == vk)
            {
                Launcher.OpenAsync("https://gabajoba.ru/");
            }
            if (sender == instagram)
            {
                Launcher.OpenAsync("https://www.instagram.com/gabajoba_/");
            }
            if (sender == youtube)
            {
                Launcher.OpenAsync("https://www.youtube.com/user/1Cu6up9lk/");
            }
            if (sender == twitter)
            {
                Launcher.OpenAsync("https://www.guillemrecolons.com/wp-content/uploads/2011/02/twitter_dead.jpg");
            }

        }

    }
    
}