using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App2.Models;

namespace App2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SnacksPage : ContentPage
    {
        public SnacksPage()
        {
            InitializeComponent();
        }
        async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string snackName = (e.CurrentSelection.FirstOrDefault() as Dish).Name;
            // This works because route names are unique in this application.            
            await Shell.Current.GoToAsync($"snacksdetails?name={snackName}");
            // The full route is shown below.
            // await Shell.Current.GoToAsync($"//animals/domestic/cats/catdetails?name={drinkName}");
        }
    }
}