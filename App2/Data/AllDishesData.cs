using App2.Models;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace App2.Data
{
    
    public static class AllDishesData
    {
        private static readonly string getURL = "https://api-eldoed.herokuapp.com/products";
        public static IList<Dish> AllDishes { get; private set; }
        //public static IList<IList<Dish>> NeBidloCode { get; set; }
        static AllDishesData()        
        {
            AllDishes = new List<Dish>();
            using (HttpClient httpClient = new HttpClient())
            {
                using (HttpRequestMessage httpRequestMessage = new HttpRequestMessage())
                {
                    httpRequestMessage.RequestUri = new Uri(getURL);
                    httpRequestMessage.Method = HttpMethod.Get;
                    httpRequestMessage.Headers.Add("null", "null");

                    Task<HttpResponseMessage> httpResponse = httpClient.SendAsync(httpRequestMessage);

                    using (HttpResponseMessage httpResponseMessage = httpResponse.Result)
                    {
                        Console.WriteLine(httpResponseMessage.ToString());

                        //response data
                        HttpContent responseContent = httpResponseMessage.Content;
                        Task<string> responseData = responseContent.ReadAsStringAsync();
                        string data = responseData.Result;

                        JSONDishesList dishesList = JsonConvert.DeserializeObject<JSONDishesList>(responseData.Result);


                        foreach (JSONDishTemplate dish in dishesList.Data)
                        {
                            AllDishes.Add(new Dish()
                            {
                                Name = dish.Name.ToString() + "test"
                                ,
                                Price = dish.Price.ToString()
                                ,
                                Details = dish.Description.ToString()
                                ,
                                ImageUrl = dish.ImageData.ToString()
                            }) ;
                            switch (dish.Category.ToString())
                            {
                                case "pizza": 
                                    {
                                        PizzaData.Pizzas.Add(new Dish
                                        {
                                            Name = "Деревенская",
                                            Price = "395 ₽",
                                            Details = "Картофель из печи, соленые огурчики, цыпленок, соус ранч, томаты, красный лук, чеснок, моцарелла, томатный соус",
                                            ImageUrl = "https://dodopizza-a.akamaihd.net/static/Img/Products/d7034033497d4703a35a2ee4185844b1_292x292.jpeg"
                                        });
                                        break; 
                                    };
                                case "snacks":
                                    {
                                        PizzaData.Pizzas.Add(new Dish
                                        {
                                            Name = "Деревенская",
                                            Price = "395 ₽",
                                            Details = "Картофель из печи, соленые огурчики, цыпленок, соус ранч, томаты, красный лук, чеснок, моцарелла, томатный соус",
                                            ImageUrl = "https://dodopizza-a.akamaihd.net/static/Img/Products/d7034033497d4703a35a2ee4185844b1_292x292.jpeg"
                                        });
                                        break;
                                    };
                                case "drinks":
                                    {
                                        PizzaData.Pizzas.Add(new Dish
                                        {
                                            Name = "Деревенская",
                                            Price = "395 ₽",
                                            Details = "Картофель из печи, соленые огурчики, цыпленок, соус ранч, томаты, красный лук, чеснок, моцарелла, томатный соус",
                                            ImageUrl = "https://dodopizza-a.akamaihd.net/static/Img/Products/d7034033497d4703a35a2ee4185844b1_292x292.jpeg"
                                        });
                                        break;
                                    };
                                case "other":
                                    {
                                        PizzaData.Pizzas.Add(new Dish
                                        {
                                            Name = "Деревенская",
                                            Price = "395 ₽",
                                            Details = "Картофель из печи, соленые огурчики, цыпленок, соус ранч, томаты, красный лук, чеснок, моцарелла, томатный соус",
                                            ImageUrl = "https://dodopizza-a.akamaihd.net/static/Img/Products/d7034033497d4703a35a2ee4185844b1_292x292.jpeg"
                                        });
                                        break;
                                    };
                                default:
                                    {

                                        break;
                                    };

                            }
                        }
                        
                    }
                }
            }
           
        }        
    }
}
