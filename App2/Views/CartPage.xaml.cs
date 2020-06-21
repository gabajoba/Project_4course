using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        
        public CartPage()
        {   
            InitializeComponent();
            foreach(DishInCart _dish in Cart.CartList)
            {
                if(_dish.Quantity == 0)
                {
                    Cart.CartList.Remove(Cart.CartList.First(x=>x.Quantity == 0));
                }
            }


            if (Cart.CartList.Count == 0)
            {
                new Label()
                {
                    Text = "Корзина пуста",
                    FontSize = 20,
                    TextColor = Color.Orange

                };
            }
            else
            {
                new Label()
                {
                    Text = "test",
                    FontSize = 20,
                    TextColor = Color.Orange

                };
            }


            var cart = new Cart();
            BindingContext = cart;
            
        }

        private void Stepper1_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            foreach (DishInCart _dish in Cart.CartList)
            {
                if (_dish.Quantity == 0)
                {
                    //((sender as Stepper).Parent.FindByName("_priceLabel") as Label).Text = "123";
                    //DisplayAlert("kek", _test1.FindByName(_dish.Name).ToString(), "OK");
                    
                    Cart.CartList.Remove(Cart.CartList.First(x => x.Quantity == 0));
                    break;
                }
            }
            

        }

    }

}
