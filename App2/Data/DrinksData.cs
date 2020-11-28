using Eldoed.Models;
using System.Collections.Generic;

namespace Eldoed.Data
{
    public static class DrinksData
    {
        public static IList<Dish> Drinks { get; private set; }

        static DrinksData()
        {
            Drinks = new List<Dish>();
        }
    }
}
