using System;
using System.Collections.Generic;
using System.Text;
using App2.Models;
namespace App2.Data
{

    class Cart
    {
        public static IList<DishInCart> CartList { get; private set; }
        static Cart()
        {

            CartList = new List<DishInCart>();

            foreach (DishInCart _dish in Cart.CartList)
            {
                if (_dish.Quantity == 0)
                {
                    Cart.CartList.Remove(_dish);
                }
            }
        }
     
    }
}
