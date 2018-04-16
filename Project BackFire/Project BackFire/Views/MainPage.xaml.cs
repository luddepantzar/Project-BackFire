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
        DispatcherTimer Timer = new DispatcherTimer();

        private MainViewModel ViewModel
        {
            get { return DataContext as MainViewModel; }
        }

        public MainPage()
        {
<<<<<<< HEAD
            InitializeComponent();
            DataContext = this;
            Timer.Tick += TimerTick;
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Start();

=======

            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.FullScreen;
            InitializeComponent();              
>>>>>>> c4ce0c41cdba7fc2ecfb638bf55dc09d021ace5d
        }

        private void TimerTick(object sender, object e)
        {
            TimeDate.Text = DateTime.Now.ToString("hh:mm");
        }

        private void DateToday( object sender, object e)
        {
            DateTime DateToday = DateTime.Today;
            TodaysDate.Text = DateTime.Today.ToString("MMMM");
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {
            string HourMinute;
<<<<<<< HEAD

            HourMinute = DateTime.Now.ToString("HH:mm");
        }

        private void button1_PointerEntered(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            button1.Visibility = Visibility.Visible;
        }

        private void button1_PointerExited(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            button1.Visibility = Visibility.Collapsed;
=======
>>>>>>> c4ce0c41cdba7fc2ecfb638bf55dc09d021ace5d
            DateTime TimeNow = new DateTime();
            TimeNow = DateTime.Now;
            string CurrentDatetime = TimeNow.ToString();
        }
<<<<<<< HEAD
=======

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

>>>>>>> c4ce0c41cdba7fc2ecfb638bf55dc09d021ace5d
    }
}
