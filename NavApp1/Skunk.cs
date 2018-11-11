using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Mono;

namespace NavApp1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false)]
    public class Skunk : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Make it show up
            SetContentView(Resource.Layout.skunk);

            // Set up the toolbar
            Android.Support.V7.Widget.Toolbar myToolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.my_toolbar);
            SetSupportActionBar(myToolbar);

            // Go back to Main
            // Not the way to do it.  I need an UP button in the toolbar.
            ImageButton mainImageButton = FindViewById<ImageButton>(Resource.Id.imageTurtleAndSkunk);
            mainImageButton.Click += MainImageButton_Click;
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.dropDownMenu, menu);
            return base.OnPrepareOptionsMenu(menu);
        }
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            if (item.ItemId == Resource.Id.file_settings)
            {
                // do something here... 
                return true;
            }
            return base.OnOptionsItemSelected(item);
        }

        private void MainImageButton_Click(object sender, EventArgs e)
        {
            Intent intentMain = new Intent(this, typeof(MainActivity));
            StartActivity(intentMain);
        }
    }
}