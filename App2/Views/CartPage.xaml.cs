using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using App2.Data;
using App2.Models;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CartPage : ContentPage
    {

        public void ShowOrderGrid()
        {
            if (Cart.CartList.Count <= 0)
            {
                this._orderGrid.IsVisible = false;
            }
            else
            {
                this._orderGrid.IsVisible = true;
            }
        }
        public CartPage()
        {
            InitializeComponent();
            ShowOrderGrid();


        }

        private void Stepper1_ValueChanged(object sender, ValueChangedEventArgs e)
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
                var pattern = "^[0-9]+\\,*[0-9]+";
                Regex regEx = new Regex(pattern);
                var _price = regEx.Match((button.Parent.FindByName("_priceLabel") as Label).Text).ToString();
                (button.Parent.FindByName("_totalPrice") as Label).Text = (Double.Parse(_price) * button.Value).ToString() + " Руб.";

            }
            _totalOrderPrice.Text = "Сумма заказа:" + Cart.CartTotal + " Руб.";
            ShowOrderGrid();

        }
        private void orderButton_Clicked(object sender, EventArgs e)
        {

        }
        private void removeButton_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var product = button?.BindingContext as DishInCart;
            var vm = BindingContext as Cart;
            vm?.RemoveCommand.Execute(product);

            ShowOrderGrid();
            _totalOrderPrice.Text = "Сумма заказа:" + Cart.CartTotal + " Руб.";
        }
    }

}
