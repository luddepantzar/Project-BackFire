using System;
using Project_BackFire.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

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
            InitializeComponent();
        }


        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {
            string HourMinute;

            HourMinute = DateTime.Now.ToString("HH:mm");
        }

        private void button1_PointerEntered(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            button1.Visibility = Visibility.Visible;
        }

        private void button1_PointerExited(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
<<<<<<< HEAD
            button1.Visibility = Visibility.Collapsed;
=======
            DateTime TimeNow = new DateTime();
            TimeNow = DateTime.Now;
            String CurrentDatetime = TimeNow.ToString();
>>>>>>> c11d9d85dd18f9f1675a84752ebd15fb1e23e18f
        }
    }
}
