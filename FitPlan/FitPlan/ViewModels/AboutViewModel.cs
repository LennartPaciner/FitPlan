using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using FitPlan.Views;

namespace FitPlan.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {

        public Command OnClick { get; }
        public AboutViewModel()
        {
            //Alles hinter binding ausm xaml hier definieren in der klasse
            Title = "Select Beispiel";
            //OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));


            OnClick = new Command(OnButtonClicked);
            
        }

        //public ICommand OpenWebCommand { get; }

        private async void OnButtonClicked(object sender)
        {
            //await Shell.Current.GoToAsync("//LoginPage");
            await Shell.Current.GoToAsync($"{nameof(HomePage)}");

        }
    }
}