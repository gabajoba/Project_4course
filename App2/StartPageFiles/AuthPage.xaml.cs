using App2.Data;
using App2.Data.User;
using Newtonsoft.Json;
using RestSharp;
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
    public partial class AuthPage : ContentPage
    {
        public AuthPage()
        {
            
            InitializeComponent();
            //((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex("#ff8256");
            //((NavigationPage)Application.Current.MainPage).Title = "Авторизация";
        }
        protected override bool OnBackButtonPressed()
        {
            // Navigation.RemovePage(Navigation.NavigationStack[Navigation.NavigationStack.Count - 1]);
            Application.Current.MainPage.Navigation.PopAsync();
            return false;
            //return base.OnBackButtonPressed();
        }

        private void authButton_Clicked(object sender, EventArgs e)
        {

            var client = new RestClient("https://api-eldoed.herokuapp.com/login");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("email", _email.Text.ToString());
            request.AddParameter("password", _pass1.Text.ToString());
            IRestResponse response = client.Execute(request);                
                     
            string responseData = response.Content.ToString();
            
            JSONauth tempUser = JsonConvert.DeserializeObject<JSONauth>(responseData);

            UserInfo.Email = tempUser.Data.Email;
            UserInfo.Message = tempUser.Message;
            UserInfo.Role = tempUser.Data.Role;
            UserInfo.Token = tempUser.Token;

            DisplayAlert(UserInfo.Email.ToString(), UserInfo.Message.ToString(), UserInfo.Role.ToString());


        }
    }
}