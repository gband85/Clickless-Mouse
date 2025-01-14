using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Net;
using System;

namespace Clickless_Mouse
{
    public partial class MainWindow : Window
    {
        const string prog_name = "Clickless Mouse";
        const string prog_version = "2.2";
        const string url_latest_version = "https://raw.githubusercontent.com/ProperCode/Clickless-Mouse/master/other/latest_version.txt";
        const string url_homepage = "github.com/ProperCode/Clickless-Mouse";
        string latest_version = "";
        const string copyright_text = "Copyright © 2019 - 2024 Mikołaj Magowski. All rights reserved.";
        string settings_filename = "settings.txt";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MIabout_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string content;
                //MyWebClient wc = new MyWebClient();
                //content = wc.DownloadString(url_latest_version);

                // latest_version = content.Replace("\r\n", "").Trim();
            }
            catch (WebException we)
            {
                latest_version = "unknown";
            }

            try
            {
                WindowAbout w = new WindowAbout();

                w.Lprogram_name.Content = prog_name;
                w.Llatest_version.Content = "Latest version: " + latest_version;
                w.Linstalled_version.Content = "Installed version: " + prog_version;
                w.Lhomepage.Content = url_homepage;
                w.Lcopyright.Content = copyright_text;

                w.Show();
            }
            catch (Exception ex)
            {
                //System.Windows.MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void MImanual_Click(object sender, RoutedEventArgs e)
        {
            WindowManual wm = new WindowManual();
            wm.Show();
        }
    }
}