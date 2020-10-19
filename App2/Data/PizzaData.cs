using App2.Models;
using System.Collections.Generic;

namespace App2.Data
{
    public static class PizzaData
    {
        public static IList<Dish> Pizzas { get; private set; }

        static PizzaData()
        {
            Pizzas = new List<Dish>();
        }
    }
}
