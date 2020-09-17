using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using App384.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(TextRecognition))]
namespace App384.Droid
{
    [Preserve(AllMembers = true)]
    [Activity(Label = "TextRecognition", Theme = "@style/Theme.AppCompat.Light.NoActionBar", MainLauncher = true)]
    public class TextRecognition : AppCompatActivity, ITextRecognition
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public void LaunchActivityInAndroid()
        {
            Console.WriteLine("LaunchActivityInAndroid");
        }

    }
}