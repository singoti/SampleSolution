using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

namespace SolutionAndroid
{
    [Activity(Label = "SolutionAndroid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);
            //sample comment
            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };

            MobileCenter.Start("de51723b-fd84-471e-97f8-49ae794f9502",
                    typeof(Analytics), typeof(Crashes));
        }
    }
}

