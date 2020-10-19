using App2.Models;
using System.Collections.Generic;

namespace App2.Data
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
