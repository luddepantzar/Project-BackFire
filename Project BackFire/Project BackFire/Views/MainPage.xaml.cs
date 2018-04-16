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
<<<<<<< HEAD
            string CurrentDatetime = TimeNow.ToString();
        }

        private void AddTime()
        {
            try
            {
                TextBlock TimeDate = MainPage.Current.FindName("TimeDate") as TextBlock;
                string sLog = TimeDate.Text;
                string sNew;
            }
            catch
            {

            }
=======
            String CurrentDatetime = TimeNow.ToString();
<<<<<<< HEAD
            HourMinute = DateTime.Now.ToString("HH:mm");
=======
>>>>>>> c11d9d85dd18f9f1675a84752ebd15fb1e23e18f
>>>>>>> b1dc87d44d204479753a732f52fa4f9f25f19461
>>>>>>> 11b9eb8390a9a9da48b92b0d04061ba98ad053b6
        }

    }
}
