﻿using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App2.Models;

namespace App2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DrinksPage : ContentPage
    {
        public DrinksPage()
        {
            InitializeComponent();
        }
        async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var collection = sender as CollectionView;
            if (collection.SelectedItem == null)
            {
                return;
            }
            else
            {
                string drinkName = (e.CurrentSelection.FirstOrDefault() as Dish).Name;                        
                await Shell.Current.GoToAsync($"drinksdetails?name={drinkName}");               
                collection.SelectedItem = null;
            }
        }
    }
}