using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microcharts;
using Rg.Plugins.Popup.Extensions;

namespace LearnApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StatisticsPage : ContentPage
    {
         
        private readonly ChartEntry[] entries = new[]
        {   
             new ChartEntry(10)
             {
                 Label = "Test 1",
                 ValueLabel = "10",
                 Color = SKColor.Parse("#2c3e50")
             },
             new ChartEntry(5)
             {
                 Label = "Test 2",
                 ValueLabel = "5",
                 Color = SKColor.Parse("#77d065")
             },
             new ChartEntry(0)
             {
                 Label = "Test 3",
                 ValueLabel = "0",
                 Color = SKColor.Parse("#b455b6")
             },
             new ChartEntry(5)
             {
                 Label = "Test 4",
                 ValueLabel = "5",
                 Color = SKColor.Parse("#3498db")
             },
              new ChartEntry(8)
             {
                 Label = "Test 5",
                 ValueLabel = "8",
                 Color = SKColor.Parse("#2c3e50")
             },
             
        };
        public StatisticsPage()
        {
            InitializeComponent();
            //Chart1.Chart =  new BarChart() { Entries = entries, PointSize=25};
            //Chart2.Chart = new LineChart()
            //{
            //    Entries = entries,
            //    LineMode = LineMode.Straight,
            //    LineSize = 8,
            //    PointMode = PointMode.Square,
            //    PointSize = 18,
            //};
        }

        private async void Button_Clicked1(object sender, EventArgs e)
        {
            
            var pop = new MessageBoxPage("Информация", "Если статистика не отображается, возможно необходимо подключится к интерненту!");
            await App.Current.MainPage.Navigation.PushPopupAsync(pop, true);
            return;
        }
    }
}