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
<<<<<<< HEAD
=======

            InitializeComponent();
>>>>>>> a67d2b47fe59170f7b09f9737cc541c17cf2ada7
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
<<<<<<< HEAD

=======
>>>>>>> a67d2b47fe59170f7b09f9737cc541c17cf2ada7
        //}

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
            this.
=======
            string HourMinute;

            HourMinute = DateTime.Now.ToString("HH:mm");
>>>>>>> a67d2b47fe59170f7b09f9737cc541c17cf2ada7
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
<<<<<<< HEAD
=======

        private void colordefault_Click(object sender, RoutedEventArgs e)
        {
            MainGrid.Background = (SolidColorBrush)Resources["BackgroundColorD"];
            MenuBar.Background = (SolidColorBrush)Resources["MenubarColorD"];
        }

        private void color1_Click(object sender, RoutedEventArgs e)
        {

            MainGrid.Background = (SolidColorBrush)Resources["BackgroundColor1"];
            MenuBar.Background = (SolidColorBrush)Resources["MenubarColor1"];

        }
        private void color2_Click(object sender, RoutedEventArgs e)
        {
            MainGrid.Background = (SolidColorBrush)Resources["BackgroundColor2"];
            MenuBar.Background = (SolidColorBrush)Resources["MenubarColor2"];
        }
        private void color3_Click(object sender, RoutedEventArgs e)
        {
            MainGrid.Background = (SolidColorBrush)Resources["BackgroundColor3"];
            MenuBar.Background = (SolidColorBrush)Resources["MenubarColor3"];
        }
>>>>>>> a67d2b47fe59170f7b09f9737cc541c17cf2ada7
    }
}
