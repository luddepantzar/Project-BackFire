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
using Windows.UI;

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
            InitializeComponent();
            DataContext = this;
            Timer.Tick += TimerTick;
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Start();
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.FullScreen;
            InitializeComponent();
        }

        private void TimerTick(object sender, object e)
        {
            TimeDate.Text = DateTime.Now.ToString("HH:mm");
            TodaysDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void changeColor()
        {
            var GreenColor = SolidColorBrush.OpacityProperty;
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

        private void SettingsMenu_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int value = rnd.Next(0,4);

            switch (value)
            {
                case 1:
                    grid1.Background = (SolidColorBrush)Resources["red"];
                    break;
                case 2:
                    grid1.Background = (SolidColorBrush)Resources["yellow"];
                    break;

                default:
                    grid1.Background = (SolidColorBrush)Resources["green"];
                    break;
            }

        }

        private void Grid1_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
