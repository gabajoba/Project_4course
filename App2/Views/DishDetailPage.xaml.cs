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
        public Dish _dish;
        public string Name
        {
            set
            {
                BindingContext = AllDishesData.AllDishes.FirstOrDefault(m => m.Name == Uri.UnescapeDataString(value));
                _dish = AllDishesData.AllDishes.FirstOrDefault(m => m.Name == Uri.UnescapeDataString(value));
            }
            get
            {
                return this.Name;
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

            var tempDish = Cart.CartList.FirstOrDefault(m => m.Name == _dish.Name);
            if (tempDish == null)
            {
                var dish = new DishInCart() { Name = _dish.Name, ImageUrl = _dish.ImageUrl, Price = _dish.Price, Quantity = 1 };
                Cart.CartList.Add(dish);
                DisplayAlert("Выполнено", "В вашу корзину добавлен товар: " + _dish.Name, "ОК");
            }
            else
            {
                tempDish.Quantity = tempDish.Quantity + 1;
                DisplayAlert("Выполнено", "В вашу корзину добавлен товар: " + _dish.Name, "ОК");
            }


            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}