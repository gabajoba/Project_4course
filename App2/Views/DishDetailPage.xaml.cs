using App2.Data;
using App2.Models;
using System;
using System.Linq;
using Xamarin.Forms;
namespace App2.Views
{
    [QueryProperty("Name", "name")]
    public partial class DishDetailPage : ContentPage
    {
        public string Name
        {
            set
            {
                BindingContext = AllDishesData.AllDishes.FirstOrDefault(m => m.Name == Uri.UnescapeDataString(value));
            }
        }
        public DishDetailPage()
        {
            InitializeComponent();
        }
        protected override bool OnBackButtonPressed()
        {
            return base.OnBackButtonPressed();
        }

        private void orderButton_Clicked(object sender, EventArgs e)
        {
            Cart.CartList.Add(new Tuple<Dish, int>(new Dish() { Name = "test", Details = "test", ImageUrl = "test", Price = "test" }, 2));
            base.OnBackButtonPressed();
        }
    }
}