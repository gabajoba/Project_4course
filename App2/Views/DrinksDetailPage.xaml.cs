using App2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.Views
{
    [QueryProperty("Name", "name")]
    public partial class DrinksDetailPage : ContentPage
    {        
        public string Name
        {
            set
            {
                BindingContext = DrinksData.Drinks.FirstOrDefault(m => m.Name == Uri.UnescapeDataString(value));
            }
        }
        public DrinksDetailPage()
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