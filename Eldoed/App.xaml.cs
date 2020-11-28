using Xamarin.Forms;

namespace Eldoed
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new StartPageFiles.StartPage())
            {
                BackgroundColor = Color.White,
                BarBackgroundColor = Color.Orange
            }; ;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
