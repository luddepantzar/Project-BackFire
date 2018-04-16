using System;
using Project_BackFire.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Input;
using Windows.UI.ViewManagement;

namespace Project_BackFire.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel
        {
            get { return DataContext as MainViewModel; }
        }

        public MainPage()
        {

            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.FullScreen;
            InitializeComponent();              
        }


        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {
            string HourMinute;
            DateTime TimeNow = new DateTime();
            TimeNow = DateTime.Now;
            String CurrentDatetime = TimeNow.ToString();
            HourMinute = DateTime.Now.ToString("HH:mm");
        }

    }
}
