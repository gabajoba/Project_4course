using App2.StartPageFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();        
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