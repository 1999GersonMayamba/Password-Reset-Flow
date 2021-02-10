using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUI.VIEW;

namespace XamarinUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new CheckEmailView())
            {
                BarBackgroundColor = Color.White
            };
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
