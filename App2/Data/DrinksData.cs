using App2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Data
{
    public static class DrinksData
    {
        public static IList<Dish> Drinks { get; private set; }

        static DrinksData()
        {
            Drinks = new List<Dish>();

            Drinks.Add(new Dish
            {
                Name = "Coca-cola Zero",
                Price = "95 ₽",
                Details = "0,5 л",
                ImageUrl = "https://dodopizza-a.akamaihd.net/static/Img/Products/Drinks/ru-RU/3f35406b-6bba-47a8-8403-c4e891f6c16e.jpg"
            });

            Drinks.Add(new Dish
            {
                Name = "Coca-cola",
                Price = "95 ₽",
                Details = "0,5 л",
                ImageUrl = "https://dodopizza-a.akamaihd.net/static/Img/Products/Drinks/ru-RU/9ad88ca5-0032-4cc4-b74e-cb236c49f64e.jpg"
            });

            Drinks.Add(new Dish
            {
                Name = "Coca-cola Vanilla",
                Price = "95 ₽",
                Details = "0,5 л",
                ImageUrl = "https://dodopizza-a.akamaihd.net/static/Img/Products/30f797d9a7054f9b9a08dab7cf65f7f1_146x146.jpeg"
            });

            Drinks.Add(new Dish
            {
                Name = "Sprite",
                Price = "95 ₽",
                Details = "0,5 л",
                ImageUrl = "https://dodopizza-a.akamaihd.net/static/Img/Products/Drinks/ru-RU/cfe01543-a245-4916-a73c-b2ea42424ca1.jpg"
            });

            Drinks.Add(new Dish
            {
                Name = "Fanta",
                Price = "95 ₽",
                Details = "0,5 л",
                ImageUrl = "https://dodopizza-a.akamaihd.net/static/Img/Products/Drinks/ru-RU/63b63cf3-1974-4652-a77d-4e2bc8a585b6.jpg"
            });

            Drinks.Add(new Dish
            {
                Name = "Fuzetea Черный с лимоном и лемонграссом",
                Price = "95 ₽",
                Details = "0,5 л",
                ImageUrl = "https://dodopizza-a.akamaihd.net/static/Img/Products/Drinks/ru-RU/fcd4b411-50ed-4777-bb12-3a5a52035202.jpg"
            });

            Drinks.Add(new Dish
            {
                Name = "Fuzetea Зеленый с манго и ромашкой",
                Price = "95 ₽",
                Details = "0,5 л",
                ImageUrl = "https://dodopizza-a.akamaihd.net/static/Img/Products/Drinks/ru-RU/a4b0982e-115d-4236-9ca4-384f5cfe7008.jpg"
            });

            Drinks.Add(new Dish
            {
                Name = "BonAqua, негаз.",
                Price = "95 ₽",
                Details = "0,5 л",
                ImageUrl = "https://dodopizza-a.akamaihd.net/static/Img/Products/Drinks/ru-RU/ad365ad0-e2c8-4086-9f0c-9b4fffc9e7a7.jpg"
            });

            Drinks.Add(new Dish
            {
                Name = "Добрый Pulpy Апельсин",
                Price = "70 ₽",
                Details = "0,45 л",
                ImageUrl = "https://dodopizza-a.akamaihd.net/static/Img/Products/4223f4e8bad64b4e94dc903104503483_146x146.jpeg"
            });
        }
    }
}
