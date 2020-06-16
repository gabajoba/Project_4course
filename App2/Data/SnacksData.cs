using App2.Models;
using System.Collections.Generic;

namespace App2.Data
{
    public static class SnacksData
    {
        public static IList<Dish> Snacks { get; private set; }

        static SnacksData()
        {
            Snacks = new List<Dish>();
        }
    }
}
