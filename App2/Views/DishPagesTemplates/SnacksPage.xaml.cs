using System.Linq;
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
            var collection = sender as CollectionView;
            if (collection.SelectedItem == null)
            {
                return;
            }
            else
            {
                string snackName = (e.CurrentSelection.FirstOrDefault() as Dish).Name;          
                await Shell.Current.GoToAsync($"snacksdetails?name={snackName}");
                collection.SelectedItem = null;
            }
        }
    }
}