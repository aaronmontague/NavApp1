﻿using System;
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

namespace NavApp1
{
    [Activity(Label = "@string/viewSkunk", Theme = "@style/AppTheme", MainLauncher = false)]
    public class Skunk : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Make it show up
            SetContentView(Resource.Layout.skunk);
        }
    }
}