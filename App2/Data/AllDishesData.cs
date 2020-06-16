using App2.Models;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace App2.Data
{
    
    public static class AllDishesData
    {
        private static readonly string getURL = "https://api-eldoed.herokuapp.com/products";       
        public static IList<Dish> AllDishes { get; private set; }
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
                            Dish temp = new Dish()
                            {
                                Name = dish.Name.ToString()
                                ,
                                Price = dish.Price.ToString() + " руб."
                                ,
                                Details = dish.Description.ToString()
                                ,
                                ImageUrl = "https://api-eldoed.herokuapp.com/" + (dish.ImageData.ToString().Replace(@"server\", "")).Replace(@"\", "/")

                            };

                            AllDishes.Add(temp);
                            switch (dish.Category.ToString())
                            {

                                case "pizza":
                                    {
                                        PizzaData.Pizzas.Add(temp);

                                        break;
                                    };

                                case "snacks":
                                    {
                                        SnacksData.Snacks.Add(temp);
                                        break;
                                    };

                                case "drinks":
                                    {
                                        DrinksData.Drinks.Add(temp);
                                        break;
                                    };

                                case "other":
                                    {
                                        OtherData.Other.Add(temp);
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
