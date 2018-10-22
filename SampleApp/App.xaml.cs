/*
* Copyright © 2018 Cloudveil Technology Inc.
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v. 2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at http://mozilla.org/MPL/2.0/.
*/

﻿
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SampleApp.Views;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SampleApp
{
    public partial class App : Application
    {
        public App()
        {

            InitializeComponent();

            // Code smell: MainPage() makes use of ModelManager, so we need to instantiate ModelManager first.
            MainPage = new NavigationPage(new SupportPage());
        }


        protected override void OnStart()
        {

        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps.
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
