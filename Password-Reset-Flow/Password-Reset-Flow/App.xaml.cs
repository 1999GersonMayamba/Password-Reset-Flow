using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Password_Reset_Flow.VIEW;

namespace Password_Reset_Flow
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
