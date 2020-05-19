using System.Linq;
using App2.Models;
using Xamarin.Forms;


namespace App2.Views
{
     public partial class PizzaPage : ContentPage
    {
        
        public PizzaPage()
        {
            InitializeComponent();
        }
        public async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string pizzaName = (e.CurrentSelection.FirstOrDefault() as Dish).Name;
            //_test1.SelectedItems.Remove(e.CurrentSelection.Count()); 
            //DisplayAlert(",", e.CurrentSelection.Count().ToString(), ",");
            await Shell.Current.GoToAsync($"pizzadetails?name={pizzaName}");
            //bug
        }
    }
}