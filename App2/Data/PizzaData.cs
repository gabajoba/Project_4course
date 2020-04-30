using App2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Data
{
    public static class PizzaData
    {
        public static IList<Dish> Pizzas { get; private set; }

        static PizzaData()
        {
            Pizzas = new List<Dish>();

            Pizzas.Add(new Dish
            {
                Name = "Деревенская",
                Price = "395 ₽",
                Details = "Картофель из печи, соленые огурчики, цыпленок, соус ранч, томаты, красный лук, чеснок, моцарелла, томатный соус",
                ImageUrl = "https://dodopizza-a.akamaihd.net/static/Img/Products/d7034033497d4703a35a2ee4185844b1_292x292.jpeg"
            });

            Pizzas.Add(new Dish
            {
                Name = "Аррива!",
                Price = "395 ₽",
                Details = "Соус бургер, цыпленок, соус ранч, чоризо, сладкий перец, красный лук, моцарелла, томаты, чеснок",
                ImageUrl = "https://dodopizza-a.akamaihd.net/static/Img/Products/e6a8b0a6818e46968acd075f521e4053_292x292.jpeg"
            });

            Pizzas.Add(new Dish
            {
                Name = "Пепперони Фреш с томатами",
                Price = "245 ₽",
                Details = "Пикантная пепперони, томатный соус, моцарелла, томаты",
                ImageUrl = "https://dodopizza-a.akamaihd.net/static/Img/Products/f57b939a4455453daade38016f61d766_292x292.jpeg"
            });

            Pizzas.Add(new Dish
            {
                Name = "Испанские колбаски чоризо",
                Price = "345 ₽",
                Details = "Острая чоризо, моцарелла, томаты, соус чипотле",
                ImageUrl = "https://dodopizza-a.akamaihd.net/static/Img/Products/750065aab4ea45268fac2f17d4c56183_292x292.jpeg"
            });

            Pizzas.Add(new Dish
            {
                Name = "Ветчина и сыр",
                Price = "295 ₽",
                Details = "Ветчина, моцарелла, сливочный соус",
                ImageUrl = "https://dodopizza-a.akamaihd.net/static/Img/Products/Pizza/ru-RU/dd59dcd5-cbf7-44e9-a5bd-1654ef06e6a3.jpg"
            });

            Pizzas.Add(new Dish
            {
                Name = "Кисло-сладкий цыпленок",
                Price = "295 ₽",
                Details = "Цыпленок, томатный соус, моцарелла, кисло-сладкий соус",
                ImageUrl = "https://dodopizza-a.akamaihd.net/static/Img/Products/Pizza/ru-RU/dcc14f3c-0bcd-4e22-9c94-d694750a790b.jpg"
            });

            Pizzas.Add(new Dish
            {
                Name = "Чизбургер-пицца",
                Price = "395 ₽",
                Details = "Мясной соус болоньезе, моцарелла, красный лук, соленые огурчики, томаты, соус бургер",
                ImageUrl = "https://dodopizza-a.akamaihd.net/static/Img/Products/Pizza/ru-RU/c7dae007-a646-49da-9240-d0d164be662c.jpg"
            });

            Pizzas.Add(new Dish
            {
                Name = "Креветки по-азиатски",
                Price = "395 ₽",
                Details = "Шампиньоны, моцарелла, креветки, кисло-сладкий соус, черный кунжут",
                ImageUrl = "https://dodopizza-a.akamaihd.net/static/Img/Products/Pizza/ru-RU/b056b128-38d4-4476-a1f0-2a3a220daa1d.jpg"
            });

            Pizzas.Add(new Dish
            {
                Name = "Пепперони",
                Price = "395 ₽",
                Details = "Пикантная пепперони, томатный соус, моцарелла",
                ImageUrl = "https://dodopizza-a.akamaihd.net/static/Img/Products/Pizza/ru-RU/4df905b0-0a43-4e95-a096-8e470918a267.jpg"
            });

            Pizzas.Add(new Dish
            {
                Name = "Четыре сыра",
                Price = "445 ₽",
                Details = "Сыр блю чиз, моцарелла, смесь сыров чеддер и пармезан, сливочный соус",
                ImageUrl = "https://dodopizza-a.akamaihd.net/static/Img/Products/Pizza/ru-RU/baf084f4-fc94-443c-a646-fdeff9f301a6.jpg"
            });

            Pizzas.Add(new Dish
            {
                Name = "Мясная 🌶️",
                Price = "445 ₽",
                Details = "Цыпленок, ветчина, пикантная пепперони, томатный соус, острая чоризо, моцарелла",
                ImageUrl = "https://dodopizza-a.akamaihd.net/static/Img/Products/Pizza/ru-RU/b61cca95-caa6-4952-94b2-6896098b4f53.jpg"
            });
        }
    }
}
