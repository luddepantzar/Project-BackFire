﻿using System;
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
using Windows.Storage;
using Windows.UI.Xaml.Media.Imaging;

namespace Project_BackFire.Views
{
    public sealed partial class Main : Page
    {
        DependencyObject ImageArray { get; set; }
        DispatcherTimer Timer = new DispatcherTimer();
        private Storyboard rotationfront1 = new Storyboard();
        private Storyboard rotationback1 = new Storyboard();
        private Storyboard rotationback2 = new Storyboard();
        private Storyboard rotationback3 = new Storyboard();
        private Storyboard rotationback4 = new Storyboard();
        private Storyboard rotationback5 = new Storyboard();
        private Storyboard rotationback6 = new Storyboard();
        private Storyboard rotationback7 = new Storyboard();
        private Storyboard rotationback8 = new Storyboard();
        private Storyboard rotationfront2 = new Storyboard();
        private Storyboard rotationfront3 = new Storyboard();
        private Storyboard rotationfront4 = new Storyboard();
        private Storyboard rotationfront5 = new Storyboard();
        private Storyboard rotationfront6 = new Storyboard();
        private Storyboard rotationfront7 = new Storyboard();
        private Storyboard rotationfront8 = new Storyboard();

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
            AnimationBack();
            AnimationFront();

        }

        public void AnimationFront()
        {
            ImageArray = { Imgbox1, Imgbox2, Imgbox3, Imgbox4, Imgbox5, Imgbox6, Imgbox7, Imgbox8 };
            //DependencyObject AllImages = ImageArray[1];
            //for(var i = 0; i < ImageArray.Length; i++)
            //{
            //    AllImages = ImageArray[i];
            //}
            DoubleAnimation animation1 = new DoubleAnimation();
            animation1.From = 0.0;
            animation1.To = 180.0;
            animation1.BeginTime = TimeSpan.FromSeconds(0);
            animation1.RepeatBehavior = new RepeatBehavior(1);
            animation1.Duration = TimeSpan.FromSeconds(3);
            Storyboard.SetTarget(animation1, ImageArray[0]);
            Storyboard.SetTargetProperty(animation1, "(UIElement.Projection).(PlaneProjection.RotationY)");
            rotationfront1.Children.Clear();
            rotationfront1.Children.Add(animation1);

            DoubleAnimation animation3 = new DoubleAnimation();
            animation3.From = 0.0;
            animation3.To = 180.0;
            animation3.BeginTime = TimeSpan.FromSeconds(0);
            animation3.RepeatBehavior = new RepeatBehavior(1);
            animation3.Duration = TimeSpan.FromSeconds(3);
            Storyboard.SetTarget(animation3, ImageArray[1]);
            Storyboard.SetTargetProperty(animation3, "(UIElement.Projection).(PlaneProjection.RotationY)");
            rotationfront2.Children.Clear();
            rotationfront2.Children.Add(animation3);

            DoubleAnimation animation5 = new DoubleAnimation();
            animation5.From = 0.0;
            animation5.To = 180.0;
            animation5.BeginTime = TimeSpan.FromSeconds(0);
            animation5.RepeatBehavior = new RepeatBehavior(1);
            animation5.Duration = TimeSpan.FromSeconds(3);
            Storyboard.SetTarget(animation5, ImageArray[2]);
            Storyboard.SetTargetProperty(animation5, "(UIElement.Projection).(PlaneProjection.RotationY)");
            rotationfront3.Children.Clear();
            rotationfront3.Children.Add(animation5);

            DoubleAnimation animation7 = new DoubleAnimation();
            animation7.From = 0.0;
            animation7.To = 180.0;
            animation7.BeginTime = TimeSpan.FromSeconds(0);
            animation7.RepeatBehavior = new RepeatBehavior(1);
            animation7.Duration = TimeSpan.FromSeconds(3);
            Storyboard.SetTarget(animation7, ImageArray[3]);
            Storyboard.SetTargetProperty(animation7, "(UIElement.Projection).(PlaneProjection.RotationY)");
            rotationfront4.Children.Clear();
            rotationfront4.Children.Add(animation7);

            DoubleAnimation animation9 = new DoubleAnimation();
            animation9.From = 0.0;
            animation9.To = 180.0;
            animation9.BeginTime = TimeSpan.FromSeconds(0);
            animation9.RepeatBehavior = new RepeatBehavior(1);
            animation9.Duration = TimeSpan.FromSeconds(3);
            Storyboard.SetTarget(animation9, ImageArray[4]);
            Storyboard.SetTargetProperty(animation9, "(UIElement.Projection).(PlaneProjection.RotationY)");
            rotationfront5.Children.Clear();
            rotationfront5.Children.Add(animation9);

            DoubleAnimation animation11 = new DoubleAnimation();
            animation11.From = 0.0;
            animation11.To = 180.0;
            animation11.BeginTime = TimeSpan.FromSeconds(0);
            animation11.RepeatBehavior = new RepeatBehavior(1);
            animation11.Duration = TimeSpan.FromSeconds(3);
            Storyboard.SetTarget(animation11, ImageArray[5]);
            Storyboard.SetTargetProperty(animation11, "(UIElement.Projection).(PlaneProjection.RotationY)");
            rotationfront6.Children.Clear();
            rotationfront6.Children.Add(animation11);

            DoubleAnimation animation13 = new DoubleAnimation();
            animation13.From = 0.0;
            animation13.To = 180.0;
            animation13.BeginTime = TimeSpan.FromSeconds(0);
            animation13.RepeatBehavior = new RepeatBehavior(1);
            animation13.Duration = TimeSpan.FromSeconds(3);
            Storyboard.SetTarget(animation13, ImageArray[6]);
            Storyboard.SetTargetProperty(animation13, "(UIElement.Projection).(PlaneProjection.RotationY)");
            rotationfront7.Children.Clear();
            rotationfront7.Children.Add(animation13);

            DoubleAnimation animation15 = new DoubleAnimation();
            animation15.From = 0.0;
            animation15.To = 180.0;
            animation15.BeginTime = TimeSpan.FromSeconds(0);
            animation15.RepeatBehavior = new RepeatBehavior(1);
            animation15.Duration = TimeSpan.FromSeconds(3);
            Storyboard.SetTarget(animation15, ImageArray[7]);
            Storyboard.SetTargetProperty(animation15, "(UIElement.Projection).(PlaneProjection.RotationY)");
            rotationfront8.Children.Clear();
            rotationfront8.Children.Add(animation15);

        }

        public void AnimationBack()
        {
            DependencyObject[] ImageArray = new DependencyObject[8] { BackImg1, BackImg2, BackImg3, BackImg4, BackImg5, BackImg6, BackImg7, BackImg8 };
            DoubleAnimation animation2 = new DoubleAnimation();
            animation2.From = 180;
            animation2.To = 360;
            animation2.BeginTime = TimeSpan.FromSeconds(0);
            animation2.RepeatBehavior = new RepeatBehavior(1);
            animation2.Duration = TimeSpan.FromSeconds(3);
            Storyboard.SetTarget(animation2, ImageArray[0]);
            Storyboard.SetTargetProperty(animation2, "(UIElement.Projection).(PlaneProjection.RotationY)");
            rotationback1.Children.Clear();
            rotationback1.Children.Add(animation2);

            DoubleAnimation animation4 = new DoubleAnimation();
            animation4.From = 180;
            animation4.To = 360;
            animation4.BeginTime = TimeSpan.FromSeconds(0);
            animation4.RepeatBehavior = new RepeatBehavior(1);
            animation4.Duration = TimeSpan.FromSeconds(3);
            Storyboard.SetTarget(animation4, ImageArray[1]);
            Storyboard.SetTargetProperty(animation4, "(UIElement.Projection).(PlaneProjection.RotationY)");
            rotationback2.Children.Clear();
            rotationback2.Children.Add(animation4);

            DoubleAnimation animation6 = new DoubleAnimation();
            animation6.From = 180;
            animation6.To = 360;
            animation6.BeginTime = TimeSpan.FromSeconds(0);
            animation6.RepeatBehavior = new RepeatBehavior(1);
            animation6.Duration = TimeSpan.FromSeconds(3);
            Storyboard.SetTarget(animation6, ImageArray[2]);
            Storyboard.SetTargetProperty(animation6, "(UIElement.Projection).(PlaneProjection.RotationY)");
            rotationback3.Children.Clear();
            rotationback3.Children.Add(animation6);

            DoubleAnimation animation8 = new DoubleAnimation();
            animation8.From = 180;
            animation8.To = 360;
            animation8.BeginTime = TimeSpan.FromSeconds(0);
            animation8.RepeatBehavior = new RepeatBehavior(1);
            animation8.Duration = TimeSpan.FromSeconds(3);
            Storyboard.SetTarget(animation8, ImageArray[3]);
            Storyboard.SetTargetProperty(animation8, "(UIElement.Projection).(PlaneProjection.RotationY)");
            rotationback4.Children.Clear();
            rotationback4.Children.Add(animation8);

            DoubleAnimation animation10 = new DoubleAnimation();
            animation10.From = 180;
            animation10.To = 360;
            animation10.BeginTime = TimeSpan.FromSeconds(0);
            animation10.RepeatBehavior = new RepeatBehavior(1);
            animation10.Duration = TimeSpan.FromSeconds(3);
            Storyboard.SetTarget(animation10, ImageArray[4]);
            Storyboard.SetTargetProperty(animation10, "(UIElement.Projection).(PlaneProjection.RotationY)");
            rotationback5.Children.Clear();
            rotationback5.Children.Add(animation10);

            DoubleAnimation animation12 = new DoubleAnimation();
            animation12.From = 180;
            animation12.To = 360;
            animation12.BeginTime = TimeSpan.FromSeconds(0);
            animation12.RepeatBehavior = new RepeatBehavior(1);
            animation12.Duration = TimeSpan.FromSeconds(3);
            Storyboard.SetTarget(animation12, ImageArray[0]);
            Storyboard.SetTargetProperty(animation12, "(UIElement.Projection).(PlaneProjection.RotationY)");
            rotationback6.Children.Clear();
            rotationback6.Children.Add(animation12);

            DoubleAnimation animation14 = new DoubleAnimation();
            animation14.From = 180;
            animation14.To = 360;
            animation14.BeginTime = TimeSpan.FromSeconds(0);
            animation14.RepeatBehavior = new RepeatBehavior(1);
            animation14.Duration = TimeSpan.FromSeconds(3);
            Storyboard.SetTarget(animation14, ImageArray[0]);
            Storyboard.SetTargetProperty(animation14, "(UIElement.Projection).(PlaneProjection.RotationY)");
            rotationback7.Children.Clear();
            rotationback7.Children.Add(animation14);

            DoubleAnimation animation16 = new DoubleAnimation();
            animation16.From = 180;
            animation16.To = 360;
            animation16.BeginTime = TimeSpan.FromSeconds(0);
            animation16.RepeatBehavior = new RepeatBehavior(1);
            animation16.Duration = TimeSpan.FromSeconds(3);
            Storyboard.SetTarget(animation16, ImageArray[0]);
            Storyboard.SetTargetProperty(animation16, "(UIElement.Projection).(PlaneProjection.RotationY)");
            rotationback8.Children.Clear();
            rotationback8.Children.Add(animation16);
        }

        private void TimerTick(object sender, object e)
        {
            TimeDate.Text = DateTime.Now.ToString("HH:mm");
            TodaysDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        public void OpacityImage2()
        {
            BackImg1.Opacity = 0;
            DispatcherTimer tm1 = new DispatcherTimer();
            tm1.Interval = TimeSpan.FromSeconds(1.4);
            tm1.Tick += (sender, args) =>
            {
                BackImg1.Opacity = 100;
                tm1.Stop();
            };
            tm1.Start();

            BackImg2.Opacity = 0;
            DispatcherTimer tm2 = new DispatcherTimer();
            tm2.Interval = TimeSpan.FromSeconds(1.4);
            tm2.Tick += (sender, args) =>
            {
                BackImg2.Opacity = 100;
                tm2.Stop();
            };
            tm2.Start();

            BackImg3.Opacity = 0;
            DispatcherTimer tm3 = new DispatcherTimer();
            tm3.Interval = TimeSpan.FromSeconds(1.4);
            tm3.Tick += (sender, args) =>
            {
                BackImg3.Opacity = 100;
                tm3.Stop();
            };
            tm3.Start();

            BackImg4.Opacity = 0;
            DispatcherTimer tm4 = new DispatcherTimer();
            tm4.Interval = TimeSpan.FromSeconds(1.4);
            tm4.Tick += (sender, args) =>
            {
                BackImg4.Opacity = 100;
                tm4.Stop();
            };
            tm4.Start();

            BackImg5.Opacity = 0;
            DispatcherTimer tm5 = new DispatcherTimer();
            tm5.Interval = TimeSpan.FromSeconds(1.4);
            tm5.Tick += (sender, args) =>
            {
                BackImg5.Opacity = 100;
                tm5.Stop();
            };
            tm5.Start();

            BackImg6.Opacity = 0;
            DispatcherTimer tm6 = new DispatcherTimer();
            tm6.Interval = TimeSpan.FromSeconds(1.4);
            tm6.Tick += (sender, args) =>
            {
                BackImg6.Opacity = 100;
                tm6.Stop();
            };
            tm6.Start();

            BackImg7.Opacity = 0;
            DispatcherTimer tm7 = new DispatcherTimer();
            tm7.Interval = TimeSpan.FromSeconds(1.4);
            tm7.Tick += (sender, args) =>
            {
                BackImg7.Opacity = 100;
                tm7.Stop();
            };
            tm7.Start();

            BackImg8.Opacity = 0;
            DispatcherTimer tm8 = new DispatcherTimer();
            tm8.Interval = TimeSpan.FromSeconds(1.4);
            tm8.Tick += (sender, args) =>
            {
                BackImg8.Opacity = 100;
                tm8.Stop();
            };
            tm8.Start();

        }

        private void Animation()
        {
            rotationfront1.Begin();
            rotationfront2.Begin();
            rotationfront3.Begin();
            rotationfront4.Begin();
            rotationfront5.Begin();
            rotationfront6.Begin();
            rotationfront7.Begin();
            rotationfront8.Begin();
            rotationback1.Begin();
            rotationback2.Begin();
            rotationback3.Begin();
            rotationback4.Begin();
            rotationback5.Begin();
            rotationback6.Begin();
            rotationback7.Begin();
            rotationback8.Begin();
            OpacityImage2();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Animation();
        }

        private void FlipCardConditions()
        {
            //switch (ImageArray)
            //{
            //    case ImageArray.Length < 8:
            //        {
            //            rotationback1.Stop();
            //            rotationfront1.Stop();
            //        }

            //    case ImageArray.Length > 8:
            //        {
            //            rotationback1.Stop();
            //            rotationfront1.Stop();
            //            DispatcherTimer tm8 = new DispatcherTimer();
            //            tm8.Interval = TimeSpan.FromSeconds(1.4);
            //            tm8.RepeatBehavior = RepeatBehavior.Forever;
            //            tm8.Tick += (sender, args) =>
            //            {
            //                rotationback1.Begin();
            //                rotationfront1.Begin();
            //                tm8.Stop();
            //            };
            //            tm8.Start();
            //        }
            //}
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
