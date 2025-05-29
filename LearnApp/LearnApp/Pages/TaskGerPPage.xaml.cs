using LearnApp.Models;
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
    public partial class TaskGerPPage : ContentPage
    {
        public TaskGerPPage()
        {
            InitializeComponent();



        }

        private async void Button_Clicked1_1(object sender, EventArgs e)
        {

            try
            {
                //int number = 1;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new TaskGerPage()));

            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }
            // await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new LearnApp.Pages.LectureP(test.Discription)));
            //await Application.Current.MainPage.DisplayAlert("Selected", lecture.Title, "OK");

            // Application.Current.MainPage.DisplayAlert("Инфа", "Здесь будет страница тестов", "OK");
        }
        private async void Button_Clicked2_1(object sender, EventArgs e)
        {

            try
            {
                //int number = 1;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new TestsGerImPage()));

            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }
            // await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new LearnApp.Pages.LectureP(test.Discription)));
            //await Application.Current.MainPage.DisplayAlert("Selected", lecture.Title, "OK");

            // Application.Current.MainPage.DisplayAlert("Инфа", "Здесь будет страница тестов", "OK");
        }
        private async void Button_Clicked3_1(object sender, EventArgs e)
        {

            try
            {
                //int number = 1;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new TFGerPage()));

            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }
            // await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new LearnApp.Pages.LectureP(test.Discription)));
            //await Application.Current.MainPage.DisplayAlert("Selected", lecture.Title, "OK");

            // Application.Current.MainPage.DisplayAlert("Инфа", "Здесь будет страница тестов", "OK");
        }

        private async void Button_Clicked4_1(object sender, EventArgs e)
        {

            try
            {
                //int number = 1;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new TestsMissGerPage()));

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