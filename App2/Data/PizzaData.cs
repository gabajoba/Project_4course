using Eldoed.Models;
using System.Collections.Generic;

namespace Eldoed.Data
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
