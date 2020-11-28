using System;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using App2.Models;
using Xamarin.Forms;

namespace App2.Data
{
    class Cart
    {
        public static ObservableCollection<DishInCart> CartList { get; private set; }

        public static double CartTotal { get; set; }

        static Cart()
        {
            CartList = new ObservableCollection<DishInCart>();
        }

        public static void RefreshCartTotal()
        {            
            try
            {
                var pattern = @"^[0-9]+\,*[0-9]+";
                Regex regEx = new Regex(pattern);
                double temp = 0;
                foreach (DishInCart dishInCart in CartList)
                {
                    temp += dishInCart.Quantity *
                        double.Parse(regEx.Match(dishInCart.Price.ToString()).ToString());
                }
                CartTotal = temp;
            } catch
            {    
                Console.WriteLine("Something went wrong");
            }
        }

        public Command<DishInCart> RemoveCommand
        {
            get
            {
                return new Command<DishInCart>((dish_) =>
                    {
                        CartList.Remove(dish_);
                        RefreshCartTotal();
                    });
            }
        }    

        
    }
}
