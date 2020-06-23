using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using App2.Models;
using App2.Views;
using Xamarin.Forms;

namespace App2.Data
{

    class Cart
    {
        public static ObservableCollection<DishInCart> CartList { get; private set; }
        public static void RefreshCartTotal()
        {
            var pattern = "^[0-9]+\\,*[0-9]+";
            Regex regEx = new Regex(pattern);
            double temp = 0;
            foreach (DishInCart dishInCart in Cart.CartList)
            {
                temp = temp + dishInCart.Quantity * Double.Parse(regEx.Match(dishInCart.Price.ToString()).ToString());
            }
            CartTotal = temp;
        }
        public Command<DishInCart> RemoveCommand
        {
            get
            {
                return new Command<DishInCart>((dish_) =>
                    {
                        CartList.Remove(dish_);
                        Cart.RefreshCartTotal();
                    });

            }
        }
        public static double CartTotal
        {
            get;
            set;
        }

        static Cart()
        {

            CartList = new ObservableCollection<DishInCart>();
        }
    }
}
