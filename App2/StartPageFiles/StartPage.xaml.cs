﻿using App2.Data.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.StartPageFiles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private async void RegButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegPage());
        }
        private async void AuthButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AuthPage());
        }

        private void SkipButton_Clicked(object sender, EventArgs e)
        {
            UserInfo.Email = null;
            UserInfo.Message = null;
            UserInfo.Role = null;
            UserInfo.Token = null;
            var page = new AppShell();
            (Application.Current.MainPage) = page;
        }
    }
}