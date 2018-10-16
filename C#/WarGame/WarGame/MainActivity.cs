using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace WarGame
{
    [Activity(Label = "WarGame", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.activity_main);

            Button button = FindViewById<Button>(Resource.Id.startGame);
            button.Click += delegate
            {
                var intent = new Intent(this, typeof(GamePlayActivity));
                StartActivity(intent);
            };
        }
    }
}

