using App2.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace App2.Data
{
    
    public static class AllDishesData
    {
        public static IList<Dish> AllDishes { get; private set; }
        public static IList<IList<Dish>> NeBidloCode { get; set; }
        static AllDishesData()
            
        {
            AllDishes = new List<Dish>();


            NeBidloCode = new List<IList<Dish>>
            {
                DrinksData.Drinks,
                PizzaData.Pizzas
            };


            foreach (List<Dish> d in NeBidloCode)
            {
                foreach (Dish _dish in d)
                {
                    AllDishes.Add(_dish);

                }
            }
            //foreach (Dish _dish in PizzaData.Pizzas)
            //    {
            //        AllDishes.Add(_dish);

            //    }
            //    foreach (Dish _dish in DrinksData.Drinks)
            //    {
            //        AllDishes.Add(_dish);
            //    Console.WriteLine(_dish.Name);
            //    }

        }
        
    }
}
