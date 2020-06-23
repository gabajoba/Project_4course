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

            if (_email.Text == "")
            {
                DisplayAlert("Ошибка", "Вы не ввели E-Mail", "OK");
            }
            else
            if (_pass1.Text == "")
            {
                DisplayAlert("Ошибка", "Вы не ввели пароль", "OK");
            }
            else
            {

                try
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

                    DisplayAlert("Выполнено", "Авторизация прошла успешно", "OK");
                    var page = new AppShell(UserInfo.Email);
                    (Application.Current.MainPage) = page;
                }
                catch
                {
                    DisplayAlert("Ошибка", "Введен неверный логин или пароль", "ОК");
                }
            }


        }
    }
}