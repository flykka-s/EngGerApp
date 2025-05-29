using Android;
using Android.Media;
using Android.Graphics;
using LearnApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Plugin.SimpleAudioPlayer;
using LearnApp.PageModels.Base;
using LearnApp.Services.Navigation;

using System.IO;
using System.Threading.Tasks;



using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;
using Java.Lang;
using Android.Opengl;
using Xamarin.CommunityToolkit.ObjectModel;
using Android.Telephony.Euicc;
using static Xamarin.Essentials.Permissions;
using Stream = Android.Media.Stream;
using LearnApp.PageModels;

namespace LearnApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectPage : ContentPage
    {
        public SelectPage()
        {
            InitializeComponent();
        }
    }
}