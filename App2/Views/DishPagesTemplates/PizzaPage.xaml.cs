using Eldoed.Models;
using System.Linq;
using Xamarin.Forms;

namespace Eldoed.Views
{
    public partial class PizzaPage : ContentPage
    {
        public PizzaPage()
        {
            InitializeComponent();
        }
        public async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var collection = sender as CollectionView;
            if (collection.SelectedItem == null)
            {
                return;
            }
            else
            {
                string pizzaName = (e.CurrentSelection.FirstOrDefault() as Dish).Name;
                await Shell.Current.GoToAsync($"pizzadetails?name={pizzaName}");
                collection.SelectedItem = null;
            }
        }
    }
}