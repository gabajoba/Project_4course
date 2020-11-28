using Eldoed.Models;
using System.Collections.Generic;

namespace Eldoed.Data
{
    public static class OtherData
    {
        public static IList<Dish> Other { get; private set; }

        static OtherData()
        {
            Other = new List<Dish>();
        }
    }
}
