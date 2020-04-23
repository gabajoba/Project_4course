using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }
        //white
        // testing github features
        //testing github features 2

        //protected override bool OnBackButtonPressed()
        //{
        //    var page = new StartPageFiles.StartPage();

        //    (Application.Current.MainPage) = page;
        //    return true;
        //    //return base.OnBackButtonPressed();
        //}




    }
}