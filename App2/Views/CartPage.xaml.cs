using Eldoed.Data;
using Eldoed.Data.User;
using Eldoed.Models;
using System;
using System.Text.RegularExpressions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Eldoed.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CartPage : ContentPage
    {
        public void ShowOrderGrid()
        {
            if (Cart.CartList.Count <= 0)
            {
                _orderGrid.IsVisible = false;
                CartEmpty.IsVisible = true;
            }
            else
            {
                _orderGrid.IsVisible = true;
                CartEmpty.IsVisible = false;
            }
        }

        public CartPage()
        {
            InitializeComponent();
            ShowOrderGrid();
        }

        private static double PriceToDouble(string price)
        {
            var pattern = "^[0-9]+\\,*[0-9]+";
            Regex regEx = new Regex(pattern);
            var temp = double.Parse(regEx.Match(price).ToString());
            return temp;
        }
        public void Stepper1_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var button = sender as Stepper;
            var product = button?.BindingContext as DishInCart;
            Cart.RefreshCartTotal();
            if (button.Value <= 0)
            {
                var vm = BindingContext as Cart;
                vm?.RemoveCommand.Execute(product);
            }
            else
            {
                var _price = PriceToDouble((button.Parent.FindByName("_priceLabel") as Label).Text);
                (button.Parent.FindByName("_totalPrice") as Label).Text = (_price * button.Value).ToString() + "руб.";

            }
            _totalOrderPrice.Text = $"Сумма заказа: {Cart.CartTotal} Руб.";
            ShowOrderGrid();
        }

        private void orderButton_Clicked(object sender, EventArgs e)
        {
            
            var temp = "";
            foreach (DishInCart dish in Cart.CartList)
            {
                temp += $"\n{dish.Name} - {dish.Quantity}шт - {dish.Quantity*dish.Price}руб.";
            }
            DisplayAlert($"{UserInfo.Email ?? "Гость"}, ваш заказ на сумму {Cart.CartTotal} рублей в пути", temp , "OK");
            Cart.CartList.Clear();
            ShowOrderGrid();
        }

        private void removeButton_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var product = button?.BindingContext as DishInCart;
            var vm = BindingContext as Cart;
            vm?.RemoveCommand.Execute(product);
            ShowOrderGrid();
            _totalOrderPrice.Text = $"Сумма заказа: {Cart.CartTotal} Руб.";
        }
    }
}
