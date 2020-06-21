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
        private string _name;
        private string _price;
        private int _quantity;
        private string _imageUrl;
        public string Name {
            get
            {
                return this._name;
            }
            set
            {
                _name = value;
            }
        }
        public string Price {
            get
            {
                return this._price;
            }
            set
            {
                _price = value;
            }

        }
        public int Quantity {
            get 
            {
                return this._quantity;
            }
            set 
            {
                _quantity = value;                
                PropertyChanged(this, new System.ComponentModel.PropertyChangingEventArgs("Quantity"));
            } 
        }

       

        public string ImageUrl {
            get
            {
                return this._imageUrl;
            }
            set
            {
                _imageUrl = value;
            }
        }
       
        private void PropertyChanged(DishInCart dishInCart, System.ComponentModel.PropertyChangingEventArgs propertyChangingEventArgs)
        {
            
        }
    }
}
