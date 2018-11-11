using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace NavApp1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            //Go to Bunny View
            Button bunnyButton = FindViewById<Button>(Resource.Id.buttonBunny);
            bunnyButton.Click += BunnyButton_Click;

            //Go to Skunk View
            Button skunkButton = FindViewById<Button>(Resource.Id.buttonSkunk);
            skunkButton.Click += SkunkButton_Click;
        }

        private void BunnyButton_Click(object sender, System.EventArgs e)
        {
            Intent intentBunny = new Intent(this, typeof(Bunny));
            StartActivity(intentBunny);
        }

        private void SkunkButton_Click(object sender, System.EventArgs e)
        {
            Intent intentSkunk = new Intent(this, typeof(Skunk));
            StartActivity(intentSkunk);
        }
    }
}