using App2.Data;
using System;
using System.Linq;
using Xamarin.Forms;

namespace App2.Views
{
    [QueryProperty("Name", "name")]
    public partial class OtherDetailPage : ContentPage
    {
        public string Name
        {
            set
            {
                BindingContext = OtherData.Other.FirstOrDefault(m => m.Name == Uri.UnescapeDataString(value));
            }
        }
        public OtherDetailPage()
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