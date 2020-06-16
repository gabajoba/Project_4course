using App2.Data;
using System;
using System.Linq;
using Xamarin.Forms;


namespace App2.Views
{
    [QueryProperty("Name", "name")]
    public partial class SnacksDetailPage : ContentPage
    {
        public string Name
        {
            set
            {
                BindingContext = SnacksData.Snacks.FirstOrDefault(m => m.Name == Uri.UnescapeDataString(value));
            }
        }
        public SnacksDetailPage()
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