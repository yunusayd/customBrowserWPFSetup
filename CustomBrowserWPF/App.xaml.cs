using CefSharp.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.IO;
using System.Windows;

namespace CefSharp.MinimalExample.Wpf
{
    public partial class App : Application
    {
        public App()
        {
            var settings = new CefSettings()
            {
                //By default CefSharp will use an in-memory cache, you need to specify a Cache Folder to persist data
                CachePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CefSharp\\Cache")
            };

            //Example of setting a command line argument
            //Enables WebRTC
            settings.CefCommandLineArgs.Add("enable-media-stream", "1");
            if (ConfigurationManager.AppSettings.AllKeys.Contains("CefSettings.RemoteDebuggingPort"))
            {
                settings.RemoteDebuggingPort = Convert.ToInt32(ConfigurationManager.AppSettings["CefSettings.RemoteDebuggingPort"]);
            }            

            //Perform dependency check to make sure all relevant resources are in our output directory.
            Cef.Initialize(settings, performDependencyCheck: true, browserProcessHandler: null);
        }
    }
}
