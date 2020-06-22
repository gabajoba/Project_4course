using App2.Data;
using App2.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace App2.Models
{
    public class DishInCart
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public int Quantity { get; set; }
        public string ImageUrl { get; set; }
     
    }
}
