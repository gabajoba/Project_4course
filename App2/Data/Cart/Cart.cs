using System;
using System.Collections.Generic;
using System.Text;
using App2.Models;
namespace App2.Data
{

    class Cart
    {
        public static IList<Tuple<Dish,int>> CartList { get; private set; }
        static Cart(){
            CartList = new List<Tuple<Dish,int>>();
           
        }
     
    }
}
