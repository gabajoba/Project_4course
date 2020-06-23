﻿using App2.Data;
using App2.StartPageFiles;
using App2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        Random rand = new Random();

        public Dictionary<string, Type> Routes { get; } = new Dictionary<string, Type>();

        public ICommand HelpCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public ICommand RandomPageCommand => new Command(async () => await NavigateToRandomPageAsync());

        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
            BindingContext = this;
        }
        public AppShell(string UserInfo)
        {
            InitializeComponent();
            RegisterRoutes();
            BindingContext = this;   
        }

        void RegisterRoutes()
        {
            Routes.Add("pizzadetails", typeof(DishDetailPage));
            Routes.Add("drinksdetails", typeof(DishDetailPage));
            Routes.Add("snacksdetails", typeof(DishDetailPage));
            Routes.Add("otherdetails", typeof(DishDetailPage));

            Routes.Add("regdetails", typeof(RegPage));
            Routes.Add("authdetails", typeof(AuthPage));
            foreach (var item in Routes)
            {
                Routing.RegisterRoute(item.Key, item.Value);
            }
        }

        async Task NavigateToRandomPageAsync()
        {
            string destinationRoute = null;
            int temp = rand.Next(0, 2);
            string dishName = null;

            switch (temp)
            {
                case 0:

                    destinationRoute = "pizzadetails";
                    dishName = PizzaData.Pizzas.ElementAt(rand.Next(0, PizzaData.Pizzas.Count)).Name;
                    break;
                case 1:
                    destinationRoute = "drinksdetails";
                    dishName = DrinksData.Drinks.ElementAt(rand.Next(0, DrinksData.Drinks.Count)).Name;
                    break;
                case 2:
                    destinationRoute = "snacksdetails";
                    dishName = SnacksData.Snacks.ElementAt(rand.Next(0, SnacksData.Snacks.Count)).Name;
                    break;
                    //case "otherdetails":
                    //destinationRoute = "otherdetails";
                    //    dishName = OtherData.Other.ElementAt(rand.Next(0, DrinksData.Drinks.Count)).Name;
                    //    break;

            }
            ShellNavigationState state = Shell.Current.CurrentState;
            await Shell.Current.GoToAsync($"{state.Location}/{destinationRoute}?name={dishName}");
            Shell.Current.FlyoutIsPresented = false;
        }

        void OnNavigating(object sender, ShellNavigatingEventArgs e)
        {


        }


        void OnNavigated(object sender, ShellNavigatedEventArgs e)
        {

        }
    }
}