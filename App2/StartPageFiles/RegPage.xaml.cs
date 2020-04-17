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
    public partial class RegPage : ContentPage
    {
        public RegPage()
        {
           
            InitializeComponent();
            //((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex("#ff8256");
            ((NavigationPage)Application.Current.MainPage).Title = "Регистрация";
        }

        protected override bool OnBackButtonPressed()
        {          
            Navigation.RemovePage(Navigation.NavigationStack[Navigation.NavigationStack.Count - 1]);
            return false;
            //return base.OnBackButtonPressed();
        }

        private void regAcceptButton_Clicked(object sender, EventArgs e)
        {
            //проверка введённых данных
            if (_username.Text == "")
            {
                DisplayAlert("Ошибка", "Введите имя", "OK");
            }
            else if (_phone.Text == "")
            {
                DisplayAlert("Ошибка", "Введите номер телефона", "OK");
            }
            else if (_mail.Text == "")
            {
                DisplayAlert("Ошибка", "Введите почту", "OK");
            }
            else if (_pass1.Text == "" || _pass2.Text == "")
            {
                DisplayAlert("Ошибка", "Введите пароль", "OK");
            }
            else if (_pass1.Text != _pass2.Text)
            {
                DisplayAlert("Ошибка", "Пароль не совпадает", "OK");
            }
            else
            {
                //всё в порядке
                DisplayAlert("", "Всё норм", "OK");
            }

        }
    }
}