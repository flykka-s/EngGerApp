using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LearnApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }


        //статистика
        private async void Button_Clicked3(object sender, EventArgs e)
        {

            try
            {

                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new StatisticsPage()));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }
            // await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new LearnApp.Pages.LectureP(test.Discription)));
            //await Application.Current.MainPage.DisplayAlert("Selected", lecture.Title, "OK");

            // Application.Current.MainPage.DisplayAlert("Инфа", "Здесь будет страница тестов", "OK");
        }
    }
}