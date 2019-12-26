using System.Configuration;
using System.Windows;
using System.Linq;
using System;

namespace CefSharp.MinimalExample.Wpf
{
    public partial class TabItem : Window
    {

        public bool WebMode
        {
            get
            {
                return ConfigurationManager.AppSettings.AllKeys.Contains("WebMode") ?
                    Convert.ToBoolean(ConfigurationManager.AppSettings["WebMode"]) : false;
            }
        }
        public String MainPage
        {
            get
            {
                return ConfigurationManager.AppSettings.AllKeys.Contains("mainPage") ?
                    ConfigurationManager.AppSettings["mainPage"] : "http://dyp.isyatirim.com.tr";
            }
        }

        public TabItem()
        {
            InitializeComponent();
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            Browser.Stop();

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {

        }

        private void frmMain_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.F5)
            {
                Browser.Reload();
            }
            else if (e.Key == System.Windows.Input.Key.F11)
            {

            }
        }
    }
}
