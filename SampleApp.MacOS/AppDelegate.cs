/*
* Copyright © 2017-2018 Cloudveil Technology Inc.
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v. 2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at http://mozilla.org/MPL/2.0/.
*/

using System;
﻿using AppKit;
using Foundation;
using Xamarin.Forms;
using Xamarin.Forms.Platform.MacOS;

namespace SampleApp.MacOS
{
    [Register("AppDelegate")]
    public class AppDelegate : FormsApplicationDelegate
    {
        NSWindow window;

        public AppDelegate()
        {
            var style = NSWindowStyle.Closable | NSWindowStyle.Resizable | NSWindowStyle.Titled;

            var rect = new CoreGraphics.CGRect(200, 200, 1024, 768);
            window = new NSWindow(rect, style, NSBackingStore.Buffered, false);
            window.Title = "Sample Application";
            window.TitleVisibility = NSWindowTitleVisibility.Hidden;
        }

        public override NSWindow MainWindow => window;

        public override void DidFinishLaunching(NSNotification notification)
        {
            Forms.Init();

            var app = new SampleApp.App();
            LoadApplication(app);

            base.DidFinishLaunching(notification);
        }

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }
    }
}
