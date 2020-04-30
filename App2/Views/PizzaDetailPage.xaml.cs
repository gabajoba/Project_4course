using App2.Data;
using System;
using System.Linq;
using Xamarin.Forms;

namespace App2.Views
{
    [QueryProperty("Name", "name")]
    public partial class PizzaDetailPage : ContentPage
    {
        public string Name
        {
            set
            {
                BindingContext = PizzaData.Pizzas.FirstOrDefault(m => m.Name == Uri.UnescapeDataString(value));
            }
        }
        public PizzaDetailPage()
        {
            InitializeComponent();
        }
        protected override bool OnBackButtonPressed()
        {
            return base.OnBackButtonPressed();
        }

        private void orderButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}