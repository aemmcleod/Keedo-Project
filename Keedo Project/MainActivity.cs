﻿using Android.App;
using Android.Widget;
using Android.OS;
using Keedo_Project.Resources.Database;
using System;

namespace Keedo_Project
{
    [Activity(Label = "Keedo_Project", MainLauncher = true)]
    public class MainActivity : Activity
    {

        private Button Clicker;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Clicker = (Button)FindViewById(Resource.Id.OrdersButtonMain);

            Clicker.Click += ClickedItem;
        }

        async void ClickedItem(object sender, EventArgs e)
        {
            Test x = new Test();
            await x.AddBook(this);
        }
    }
}

