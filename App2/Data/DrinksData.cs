using App2.Models;
using System.Collections.Generic;

namespace App2.Data
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
