using Eldoed.Models;
using System.Collections.Generic;

namespace Eldoed.Data
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
