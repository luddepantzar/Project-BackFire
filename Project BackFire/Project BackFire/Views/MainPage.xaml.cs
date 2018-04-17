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
using Microsoft.Xaml.Interactivity;
using Windows.UI.Xaml.Media.Animation;
using Windows.Graphics.Effects;

namespace Project_BackFire.Views
{
    public sealed partial class MainPage : Page
    {
        DispatcherTimer Timer = new DispatcherTimer();
        private Storyboard rotation = new Storyboard();

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
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 0.0;
            animation.To = 360.0;
            animation.BeginTime = TimeSpan.FromSeconds(1);
            animation.RepeatBehavior = RepeatBehavior.Forever;
            Storyboard.SetTarget(animation, Img1);
            Storyboard.SetTargetProperty(animation, "(UIElement.Projection).(PlaneProjecton.RotationY)");
            rotation.Children.Clear();
            rotation.Children.Add(animation);
            switch (animation.To)
            {
                case 180.0:
                    {
                        rotation.Stop();
                        break;
                    }

                case 360.0:
                    {
                        rotation.Stop();
                        break;
                    }

                default:
                    {
                        rotation.Begin();
                        break;
                    }
            }
        }

        private void TimerTick(object sender, object e)
        {
            TimeDate.Text = DateTime.Now.ToString("HH:mm");
            TodaysDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            rotation.Begin();
        }

        private void Img1_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            rotation.Begin();
        }

        private void Img1_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            rotation.Stop();
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
                    Grid1.Background = (SolidColorBrush)Resources["red"];
                    break;
                case 2:
                    Grid1.Background = (SolidColorBrush)Resources["yellow"];
                    break;

                default:
                    Grid1.Background = (SolidColorBrush)Resources["green"];
                    break;
            }

        }
    }
}
