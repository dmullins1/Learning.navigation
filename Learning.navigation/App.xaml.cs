using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Learning.navigation
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
            (MainPage as NavigationPage).BarBackgroundColor = (Color)Application.Current.Resources["Primary"];

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
