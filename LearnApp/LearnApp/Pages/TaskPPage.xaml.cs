using Android.Widget;
using LearnApp.Models;
using LearnApp.PageModels;
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
    public partial class TaskPPage : ContentPage
    {
        public TaskPPage()
        {
            InitializeComponent();



        }

        private async void Button_Clicked1_1(object sender, EventArgs e)
        {

            try
            {
                //int number = 1;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new TaskPage()));

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
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new TFPage()));

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
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new TestsImPage()));

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
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new TestsMissPage()));

            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }
            // await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new LearnApp.Pages.LectureP(test.Discription)));
            //await Application.Current.MainPage.DisplayAlert("Selected", lecture.Title, "OK");

            // Application.Current.MainPage.DisplayAlert("Инфа", "Здесь будет страница тестов", "OK");
        }
        //private async void Button_Clicked2_1(object sender, EventArgs e)
        //{

        //    try
        //    {
        //        object args1 = new {
        //            Chapter = "Глава 1",
        //            Complited = "dodgerblue",
        //            CorrectCount = 0,
        //            Discription1 = "Detached house \nотдельно стоящий дом",
        //            Discription2 = "Semi-detached (house) \nдом, имеющий общую стену с соседним домом",
        //            Discription3 = "Terraced house \nдом, имеющий общие стены с соседними домами",
        //            Discription4 = "Flat / Apartament \nквартира",
        //            Discription5 = "Block of flats \nмногоэтажка",
        //            Discription6 = "Hostel \nобщежитие",
        //            Discription7 = "Cottage \nнебольшой дом в сельской местности",
        //            Discription8 = "Bungalow \nодноэтажный небольшой домик",
        //            Discription9 = "Close to \nрядом с",
        //            Discription10 = "Right in the center \nпрямо в центре",
        //            Discription11 = "On the outskirts \nна окраине",
        //            Discription12 = "In the suburbs \nв пригороде",
        //            Discription13 = "Own \nвладеть",
        //            Discription14 = "Rent \nснимать (квартиру и т.п.)",
        //            Discription15 = "Share \nделить / делиться",
        //            Discription16 = "Tiny \nкрошечный",
        //            Discription17 = "Huge \nогромный",
        //            Discription18 = "Quiet \nтихий",
        //            Discription19 = "Noisy \nшумный",
        //            Discription20 = "Dark \nтемный",
        //            Discription21 = "Light \nсветлый",
        //            Discription22 = "Spacious \nпросторный",
        //            Discription23 = "Attic \nчердак",
        //            Discription24 = "Basement \nподвал",
        //            Discription25 = "Bedroom \nспальня",
        //            Discription26 = "Living room / Lounge \nгостинная",
        //            Discription27 = "Dining room \nстоловая",
        //            Discription28 = "Kitchen \nкухня",
        //            Discription29 = "Bathroom \nванная",
        //            Discription30 = "Shower \nдуш",
        //            Discription31 = "WC / Toilet \nтуалет",
        //            Discription32 = "Nursery \nдетская комната",
        //            Discription33 = "Study \nкабинет",
        //            Discription34 = "",
        //            Discription35 = "",
        //            Discription36 = "",
        //            Discription37 = "Central heating \nцентральное отопление",
        //            Discription38 = "Cooling \nсистема охлаждения",
        //            Discription39 = "Water supply \nводоснабжение",
        //            Discription40 = "Electricity \nэлектричество",
        //            Discription41 = "",
        //            Discription42 = "",
        //            Discription43 = "Ceiling \nпотолок",
        //            Discription44 = "Floor \nпол",
        //            Discription45 = "Fireplace \nкамин",
        //            Discription46 = "Microwave \nмикроволновая печь",
        //            Discription47 = "Fridge \nхолодильник",
        //            Discription48 = "Freezer \nморозильник",
        //            Discription49 = "Dishwasher \nпосудомоечная машина",
        //            Discription50 = "Cooker \nплита",
        //            Discription51 = "",
        //            Discription52 = "",
        //            Discription53 = "Washing machine \nстиральная машина",
        //            Discription54 = "",
        //            Discription55 = "",
        //            Discription56 = "Carpet \nковёр",
        //            Discription57 = "Mirror \nзеркало",
        //            Discription58 = "Сurtains \nзанавески",
        //            Discription59 = "",
        //            Discription60 = "Comfy chair \nкресло",
        //            Discription61 = "",
        //            Discription62 = "Sofa \nдиван",
        //            Discription63 = "Sink \nраковина",
        //            Discription64 = "Tap \nкран",
        //            Discription65 = "",
        //            Discription66 = "",
        //            Discription67 = "",
        //            Discription68 = "",
        //            Discription69 = "",
        //            Discription70 = "",
        //            Discription71 = "",
        //            Discription72 = "",
        //            Discription73 = "",
        //            Discription74 = "",
        //            Discription75 = "",
        //            Discription76 = "",
        //            Discription77 = "",
        //            Discription78 = "",
        //            Discription79 = "",
        //            Id = 0,
        //            Image1 = (object)null,
        //            Image2 = (object)null,
        //            Preload = "Тест на проверку знаний по Главе Education",
        //            QuestionTrueFalse = 5,
        //            TestNumber = "1",
        //            Title = "Houses and homes",
        //            VideoLink = "https://www.youtube.com/watch?v=IGObF-WSKUo",
        //            WrongCount = 0,
        //            currentQuestion = (object)null,
        //            currentindexquestion = 0,

        //        };
        //        var Lec = args1 as LearnApp.Models.Lecture;
        //        // Lecture _lecture = LearnApp.Models.Lecture;
        //        //int number = 1;
        //         await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new Page1(Lec)));

        //    }
        //    catch (System.Exception ex)
        //    {
        //        Console.WriteLine(ex);
        //    }
        //    // await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new LearnApp.Pages.LectureP(test.Discription)));
        //    //await Application.Current.MainPage.DisplayAlert("Selected", lecture.Title, "OK");

        //    // Application.Current.MainPage.DisplayAlert("Инфа", "Здесь будет страница тестов", "OK");
        //}
    }
}