﻿using Android.Widget;
using HelloLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnButtonClicked(object sender, EventArgs args)
        {
            string username = usernameEntry.Text;
            string helloMessage = HelloClass.GenerateWelcomeString(DateTime.Now, username);

            DisplayAlert("w/sup buddy?", helloMessage, "k");
        }
    }
}
