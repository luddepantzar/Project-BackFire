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
<<<<<<< HEAD

=======
>>>>>>> 7059df6eb3e3286d3a194cddd7da350e62cdc460
            string CurrentDatetime = TimeNow.ToString();
        }
<<<<<<< HEAD
=======

     

>>>>>>> c4ce0c41cdba7fc2ecfb638bf55dc09d021ace5d
    }
}
