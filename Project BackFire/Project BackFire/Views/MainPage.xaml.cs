using System;
using Project_BackFire.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Input;
using Windows.UI.ViewManagement;
using System.Globalization;
using System.Threading;

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
            DataContext = this;
            Timer.Tick += TimerTick;
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Start();
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.FullScreen;
            InitializeComponent();              
        }

        private void TimerTick(object sender, object e)
        {
            TimeDate.Text = DateTime.Now.ToString("MM/ddhh:mm");
        }

        //private void DateToday( object sender, object e)
        //{
        //    DateTime DateToday = DateTime.Today;
        //    TodaysDate.Text = DateTime.Today.ToString("MMMM");

        //}

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {
            this.
        }

        private void button1_PointerEntered(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            btn1.Visibility = Visibility.Visible;
        }

        private void button1_PointerExited(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            btn1.Visibility = Visibility.Collapsed;
            DateTime TimeNow = new DateTime();
            TimeNow = DateTime.Now;
            string CurrentDatetime = TimeNow.ToString();
        }
    }
}
