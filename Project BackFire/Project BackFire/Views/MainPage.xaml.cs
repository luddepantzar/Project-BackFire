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
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;
namespace Project_BackFire.Views
{
    public sealed partial class Main : Page
    {
        DispatcherTimer Timer = new DispatcherTimer();
        private Storyboard rotationfront = new Storyboard();
        private Storyboard rotationback = new Storyboard();

        private MainViewModel ViewModel
        {
            get { return DataContext as MainViewModel; }
        }

        public Main()
        {
            InitializeComponent();
            DataContext = this;
            Timer.Tick += TimerTick;
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Start();
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.FullScreen;

            InitializeComponent();
            DoubleAnimation animation1 = new DoubleAnimation();
            animation1.From = 0.0;
            animation1.To = 180.0;
            animation1.BeginTime = TimeSpan.FromSeconds(0);
            animation1.RepeatBehavior = new RepeatBehavior(1);
            Storyboard.SetTarget(animation1, Img1);
            Storyboard.SetTargetProperty(animation1, "(UIElement.Projection).(PlaneProjection.RotationY)");
            rotationfront.Children.Clear();
            rotationfront.Children.Add(animation1);

            DoubleAnimation animation2 = new DoubleAnimation();
            animation2.From = 180;
            animation2.To = 360;
            animation2.BeginTime = TimeSpan.FromSeconds(0);
            animation2.RepeatBehavior = new RepeatBehavior(1);
            Storyboard.SetTarget(animation2, Image2);
            Storyboard.SetTargetProperty(animation2, "(UIElement.Projection).(PlaneProjection.RotationY)");
            rotationback.Children.Clear();
            rotationback.Children.Add(animation2);

            
        


    }

        private void TimerTick(object sender, object e)
        {
            TimeDate.Text = DateTime.Now.ToString("HH:mm");
            TodaysDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void OpacityImage2()
        {
            Image2.Opacity = 0;
            DispatcherTimer tm = new DispatcherTimer();
            tm.Interval = TimeSpan.FromSeconds(0.5);
            tm.Tick += (sender, args) =>
            {
                Image2.Opacity = 100;
                tm.Stop();
            };
            tm.Start();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            rotationfront.Begin();
            rotationback.Begin();
            OpacityImage2();
        }

        private void Img1_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            rotationfront.Begin();
            rotationback.Begin();
            OpacityImage2();
        }

        private void Img1_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            rotationfront.Stop();
            rotationback.Stop();
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
            ContentArea.Background = (SolidColorBrush)Resources["BackgroundColorD"];
            MenuBar.Background = (SolidColorBrush)Resources["MenubarColorD"];
        }

        private void color1_Click(object sender, RoutedEventArgs e)
        {

            ContentArea.Background = (SolidColorBrush)Resources["BackgroundColor1"];
            MenuBar.Background = (SolidColorBrush)Resources["MenubarColor1"];

        }
        private void color2_Click(object sender, RoutedEventArgs e)
        {
            ContentArea.Background = (SolidColorBrush)Resources["BackgroundColor2"];
            MenuBar.Background = (SolidColorBrush)Resources["MenubarColor2"];
        }
        private void color3_Click(object sender, RoutedEventArgs e)
        {
            ContentArea.Background = (SolidColorBrush)Resources["BackgroundColor3"];
            MenuBar.Background = (SolidColorBrush)Resources["MenubarColor3"];


        }

        private void SettingsMenu_Click(object sender, RoutedEventArgs e)
        {
            /*
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
            */
        }

      
    }
}
