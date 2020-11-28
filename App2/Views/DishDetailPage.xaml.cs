using Eldoed.Data;
using Eldoed.Models;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace Eldoed.Views
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
                return Name;
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

        private static double PriceToDouble(string price)
        {
            var pattern = @"^[0-9]+\,*[0-9]+";
            Regex regEx = new Regex(pattern);
            var temp = double.Parse(regEx.Match(price).ToString());
            return temp;
        }

        private void orderButton_Clicked(object sender, EventArgs e)
        {
            var tempDish = Cart.CartList.FirstOrDefault(m => m.Name == _dish.Name);

            if (tempDish == null)
            {
                var dish = new DishInCart() {
                    Name = _dish.Name,
                    ImageUrl = _dish.ImageUrl,
                    Price = PriceToDouble(_dish.Price),
                    Quantity = 1
                };
                Cart.CartList.Add(dish);
                DisplayAlert("Выполнено", $"В вашу корзину добавлен товар: {_dish.Name}", "ОК");
            }
            else
            {
                //Cart.CartList.FirstOrDefault(m => m.Name == _dish.Name).Quantity += 1;               
                DisplayAlert("Внимание", $"В вашей корзине уже присутствует данный товар: {_dish.Name}", "ОК");               
            }
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}