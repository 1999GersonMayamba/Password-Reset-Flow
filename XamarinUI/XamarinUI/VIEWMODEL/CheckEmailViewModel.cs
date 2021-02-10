using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using XamarinUI.VIEW;

namespace XamarinUI.VIEWMODEL
{
   public class CheckEmailViewModel: INotifyPropertyChanged
    {

        public Command TapCommand { get; }
        public Command ClickComand { get; }
        public CheckEmailViewModel()
        {
            TapCommand = new Command(OnTappedAsync);
            ClickComand = new Command(ClickAsync);
        }

        private void OnTappedAsync()
        {
            Application.Current.MainPage.Navigation.PushAsync(new ResetPasswordView());
        }

        private void ClickAsync()
        {
            Application.Current.MainPage.Navigation.PushAsync(new CreateNewPasswordView());
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
