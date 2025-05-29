using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Firebase.Firestore;
using Android.Graphics;
using Firebase.Storage;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;

namespace LearnApp.Droid.Services
{
    public class GetImage
    {
        private readonly FirebaseStorage _storage = FirebaseStorage.Instance;
        private readonly string _bucketUrl = "gs://learnapp-e035f.appspot.com";

        public async Task<Bitmap> GetBitmapAsync(string name)
        {
            var imageRef = _storage.GetReferenceFromUrl($"{_bucketUrl}/English_Educ/education.jpg");
            var url = await imageRef.GetDownloadUrlAsync();
            var httpClient = new HttpClient();
            var imageStream = await httpClient.GetStreamAsync(url.ToString());
            var bitmap = await BitmapFactory.DecodeStreamAsync(imageStream);
            return bitmap;
        }
    }
}