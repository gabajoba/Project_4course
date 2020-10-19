using App2.Data;
using App2.Data.User;
using Newtonsoft.Json;
using RestSharp;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.StartPageFiles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegPage : ContentPage
    {
        public RegPage()
        {
            InitializeComponent();         
        }

        protected override bool OnBackButtonPressed()
        {           
            Application.Current.MainPage.Navigation.PopAsync();
            return false;
        }

        private void regAcceptButton_Clicked(object sender, EventArgs e)
        {
            // var pattern = "^[0-9][(][0-9]{3}[)][0-9]{3}[-][0-9]{2}[-][0-9]{2}$";
            // Regex regEx = new Regex(pattern);
            //проверка введённых данных
            //if (_username.Text == "")
            //{
            //    DisplayAlert("Ошибка", "Введите имя", "OK");
            //}
            //else if (regEx.IsMatch(_phone.Text) == false)
            //{               
            //        DisplayAlert("Ошибка", "Некорректно введен номер телефона", "ОК");               
            //}
            //else 
            if (_mail.Text == "")
            {
                DisplayAlert("Ошибка", "Введите почту", "OK");
            }
            else if (_pass1.Text == "" || _pass2.Text == "")
            {
                DisplayAlert("Ошибка", "Введите пароль", "OK");
            }
            else if (_pass1.Text != _pass2.Text)
            {
                DisplayAlert("Ошибка", "Пароли не совпадают", "OK");
            }
            else
            {
                try
                {
                    var client = new RestClient("https://api-eldoed.herokuapp.com/signup");
                    client.Timeout = -1;
                    var request = new RestRequest(Method.POST);
                    request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                    request.AddParameter("email", _mail.Text.ToString());
                    request.AddParameter("password", _pass1.Text.ToString());
                    IRestResponse response = client.Execute(request);

                    string responseData = response.Content.ToString();

                    JSONauth tempUser = JsonConvert.DeserializeObject<JSONauth>(responseData);

                    UserInfo.Email = tempUser.Data.Email;
                    UserInfo.Message = tempUser.Message;
                    UserInfo.Role = tempUser.Data.Role;
                    UserInfo.Token = tempUser.Token;

                    DisplayAlert("Выполнено", "Регистрация прошла успешно", "OK");
                    var page = new AppShell(UserInfo.Email);
                    (Application.Current.MainPage) = page;
                }
                catch
                {
                    DisplayAlert("Что-то пошло не так", "Возможно пользователь с таким E-Mail-ом уже существует", "ОК");
                }
            }
        }
    }
}