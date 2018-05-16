﻿using System;
using Project_BackFire.ViewModels;
using Project_BackFire;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Media.Imaging;
using Project_BackFire.Models;
using System.Net;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using Microsoft.Toolkit.Uwp.UI.Animations;
using Windows.UI.Xaml.Media;
using Windows.UI;
using System.Collections.ObjectModel;

namespace Project_BackFire.Views
{
    public partial class Main : Page
    {
        List<DependencyObject> List { get; set; }

        DependencyObject ImageArray { get; set; }

        public ObservableCollection<Attributes> attributes;


        public DispatcherTimer DisTimer = new DispatcherTimer();

        private TimeSpan SpanTime;


        private MainViewModel ViewModel
        {
            get { return DataContext as MainViewModel; }
        }

        public Main()
        {
            InitializeComponent();
            DataContext = this;
            DisTimer.Tick += TimerTick;
            DisTimer.Interval = new TimeSpan(0, 0, 1);
            DisTimer.Start();
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.FullScreen;
            //AnimationBack();
            //AnimationFront();                     
            //FlipCardConditions();

            attributes = new ObservableCollection<Attributes>();
            attributes.Add(new Attributes { RoomID = 1, RoomName = "Rum 1", Projector = true, Wboard = false, Tv = false, Wifi = true, Seats = 5, Note = "Lorem ipsum dolor sit amet, co" });
            attributes.Add(new Attributes { RoomID = 2, RoomName = "Rum 2", Projector = false, Wboard = true, Tv = true, Wifi = true, Seats = 10 });
            attributes.Add(new Attributes { RoomID = 3, RoomName = "Rum 3", Projector = false, Wboard = false, Tv = true, Wifi = false, Seats = 4 });
            attributes.Add(new Attributes { RoomID = 4, RoomName = "Rum 4", Projector = true, Wboard = true, Tv = false, Wifi = true, Seats = 15 });
            attributes.Add(new Attributes { RoomID = 5, RoomName = "Rum 5", Projector = true, Wboard = false, Tv = false, Wifi = true, Seats = 7 });
            attributes.Add(new Attributes { RoomID = 6, RoomName = "Rum 6", Projector = false, Wboard = true, Tv = true, Wifi = false, Seats = 22 });
            attributes.Add(new Attributes { RoomID = 7, RoomName = "Rum 7", Projector = false, Wboard = false, Tv = true, Wifi = true, Seats = 12 });
            attributes.Add(new Attributes { RoomID = 8, RoomName = "Rum 8", Projector = true, Wboard = true, Tv = false, Wifi = false, Seats = 30 });

        }

        async void Getname()
        {
            string url = "https://api.rumsbokning.nu/api/companies/aab96aa1-d8ca-4f74-8e35-ded190c38dd4";

            BitmapImage image = new BitmapImage(new Uri("https://api.rumsbokning.nu/api/companies/aab96aa1-d8ca-4f74-8e35-ded190c38dd4/image"));

            HttpClient client = new HttpClient();

            string response = await client.GetStringAsync(url);

            var data = JsonConvert.DeserializeObject<Rootobject>(response);

            switch (data.code)
            {
                case "1234":
                    {
                        Logo.Source = image;
                        ContentArea.Background = (LinearGradientBrush)Resources["Test"];
                        MenuBar.Background = (LinearGradientBrush)Resources["MenuTest"];
                        break;
                    }

                default:
                    {
                        break;
                    }
            }
        }

        public async void InputApiBox()
        {
            string url = "https://api.rumsbokning.nu/api/companies/aab96aa1-d8ca-4f74-8e35-ded190c38dd4";

            BitmapImage image = new BitmapImage(new Uri("https://api.rumsbokning.nu/api/companies/aab96aa1-d8ca-4f74-8e35-ded190c38dd4/image"));

            HttpClient client = new HttpClient();

            string response = await client.GetStringAsync(url);

            var data = JsonConvert.DeserializeObject<Rootobject>(response);

            if (ApiInput.Password == data.code)
            {
                Getname();
            }
        }

        private void ApiSubmitBut_Click(object sender, RoutedEventArgs e)
        {
            ApiContainer.Visibility = Visibility.Visible;
            InputApiBox();
        }

        //public void AnimationFront()
        //{
        //    DoubleAnimation animation1 = new DoubleAnimation();
        //    animation1.From = 0.0;
        //    animation1.To = 180.0;
        //    animation1.BeginTime = TimeSpan.FromSeconds(0);
        //    animation1.RepeatBehavior = new RepeatBehavior(1);
        //    animation1.Duration = TimeSpan.FromSeconds(3);
        //    Storyboard.SetTarget(animation1, List[0]);
        //    Storyboard.SetTargetProperty(animation1, "(UIElement.Projection).(PlaneProjection.RotationY)");
        //   // rotationfront1.Children.Clear();
        //    rotationfront1.Children.Add(animation1);

        //    DoubleAnimation animation3 = new DoubleAnimation();
        //    animation3.From = 0.0;
        //    animation3.To = 180.0;
        //    animation3.BeginTime = TimeSpan.FromSeconds(0);
        //    animation3.RepeatBehavior = new RepeatBehavior(1);
        //    animation3.Duration = TimeSpan.FromSeconds(3);
        //    Storyboard.SetTarget(animation3, List[1]);
        //    Storyboard.SetTargetProperty(animation3, "(UIElement.Projection).(PlaneProjection.RotationY)");
        //    //rotationfront2.Children.Clear();
        //    rotationfront2.Children.Add(animation3);

        //    DoubleAnimation animation5 = new DoubleAnimation();
        //    animation5.From = 0.0;
        //    animation5.To = 180.0;
        //    animation5.BeginTime = TimeSpan.FromSeconds(0);
        //    animation5.RepeatBehavior = new RepeatBehavior(1);
        //    animation5.Duration = TimeSpan.FromSeconds(3);
        //    Storyboard.SetTarget(animation5, List[2]);
        //    Storyboard.SetTargetProperty(animation5, "(UIElement.Projection).(PlaneProjection.RotationY)");
        //    //rotationfront3.Children.Clear();
        //    rotationfront3.Children.Add(animation5);

        //    DoubleAnimation animation7 = new DoubleAnimation();
        //    animation7.From = 0.0;
        //    animation7.To = 180.0;
        //    animation7.BeginTime = TimeSpan.FromSeconds(0);
        //    animation7.RepeatBehavior = new RepeatBehavior(1);
        //    animation7.Duration = TimeSpan.FromSeconds(3);
        //    Storyboard.SetTarget(animation7, List[3]);
        //    Storyboard.SetTargetProperty(animation7, "(UIElement.Projection).(PlaneProjection.RotationY)");
        //  //rotationfront4.Children.Clear();
        //    rotationfront4.Children.Add(animation7);

        //    DoubleAnimation animation9 = new DoubleAnimation();
        //    animation9.From = 0.0;
        //    animation9.To = 180.0;
        //    animation9.BeginTime = TimeSpan.FromSeconds(0);
        //    animation9.RepeatBehavior = new RepeatBehavior(1);
        //    animation9.Duration = TimeSpan.FromSeconds(3);
        //    Storyboard.SetTarget(animation9, List[4]);
        //    Storyboard.SetTargetProperty(animation9, "(UIElement.Projection).(PlaneProjection.RotationY)");
        //   // rotationfront5.Children.Clear();
        //    rotationfront5.Children.Add(animation9);

        //    DoubleAnimation animation11 = new DoubleAnimation();
        //    animation11.From = 0.0;
        //    animation11.To = 180.0;
        //    animation11.BeginTime = TimeSpan.FromSeconds(0);
        //    animation11.RepeatBehavior = new RepeatBehavior(1);
        //    animation11.Duration = TimeSpan.FromSeconds(3);
        //    Storyboard.SetTarget(animation11, List[5]);
        //    Storyboard.SetTargetProperty(animation11, "(UIElement.Projection).(PlaneProjection.RotationY)");
        //   // rotationfront6.Children.Clear();
        //    rotationfront6.Children.Add(animation11);

        //    DoubleAnimation animation13 = new DoubleAnimation();
        //    animation13.From = 0.0;
        //    animation13.To = 180.0;
        //    animation13.BeginTime = TimeSpan.FromSeconds(0);
        //    animation13.RepeatBehavior = new RepeatBehavior(1);
        //    animation13.Duration = TimeSpan.FromSeconds(3);
        //    Storyboard.SetTarget(animation13, List[6]);
        //    Storyboard.SetTargetProperty(animation13, "(UIElement.Projection).(PlaneProjection.RotationY)");
        //    //rotationfront7.Children.Clear();
        //    rotationfront7.Children.Add(animation13);

        //    DoubleAnimation animation15 = new DoubleAnimation();
        //    animation15.From = 0.0;
        //    animation15.To = 180.0;
        //    animation15.BeginTime = TimeSpan.FromSeconds(0);
        //    animation15.RepeatBehavior = new RepeatBehavior(1);
        //    animation15.Duration = TimeSpan.FromSeconds(3);
        //    Storyboard.SetTarget(animation15, List[7]);
        //    Storyboard.SetTargetProperty(animation15, "(UIElement.Projection).(PlaneProjection.RotationY)");
        //   // rotationfront8.Children.Clear();
        //    rotationfront8.Children.Add(animation15);
        //}

        //public void AnimationBack()
        //{
        //    DependencyObject[] list = new DependencyObject[8] { BackImg1, BackImg2, BackImg3, BackImg4, BackImg5, BackImg6, BackImg7, BackImg8 };
        //    DoubleAnimation animation2 = new DoubleAnimation();
        //    animation2.From = 180;
        //    animation2.To = 360;
        //    animation2.BeginTime = TimeSpan.FromSeconds(0);
        //    animation2.RepeatBehavior = new RepeatBehavior(1);
        //    animation2.Duration = TimeSpan.FromSeconds(3);
        //    Storyboard.SetTarget(animation2, list[0]);
        //    Storyboard.SetTargetProperty(animation2, "(UIElement.Projection).(PlaneProjection.RotationY)");
        //   // rotationback1.Children.Clear();
        //    rotationback1.Children.Add(animation2);

        //    DoubleAnimation animation4 = new DoubleAnimation();
        //    animation4.From = 180;
        //    animation4.To = 360;
        //    animation4.BeginTime = TimeSpan.FromSeconds(0);
        //    animation4.RepeatBehavior = new RepeatBehavior(1);
        //    animation4.Duration = TimeSpan.FromSeconds(3);
        //    Storyboard.SetTarget(animation4, list[1]);
        //    Storyboard.SetTargetProperty(animation4, "(UIElement.Projection).(PlaneProjection.RotationY)");
        //   // rotationback2.Children.Clear();
        //    rotationback2.Children.Add(animation4);

        //    DoubleAnimation animation6 = new DoubleAnimation();
        //    animation6.From = 180;
        //    animation6.To = 360;
        //    animation6.BeginTime = TimeSpan.FromSeconds(0);
        //    animation6.RepeatBehavior = new RepeatBehavior(1);
        //    animation6.Duration = TimeSpan.FromSeconds(3);
        //    Storyboard.SetTarget(animation6, list[2]);
        //    Storyboard.SetTargetProperty(animation6, "(UIElement.Projection).(PlaneProjection.RotationY)");
        //  //  rotationback3.Children.Clear();
        //    rotationback3.Children.Add(animation6);

        //    DoubleAnimation animation8 = new DoubleAnimation();
        //    animation8.From = 180;
        //    animation8.To = 360;
        //    animation8.BeginTime = TimeSpan.FromSeconds(0);
        //    animation8.RepeatBehavior = new RepeatBehavior(1);
        //    animation8.Duration = TimeSpan.FromSeconds(3);
        //    Storyboard.SetTarget(animation8, list[3]);
        //    Storyboard.SetTargetProperty(animation8, "(UIElement.Projection).(PlaneProjection.RotationY)");
        //   // rotationback4.Children.Clear();
        //    rotationback4.Children.Add(animation8);

        //    DoubleAnimation animation10 = new DoubleAnimation();
        //    animation10.From = 180;
        //    animation10.To = 360;
        //    animation10.BeginTime = TimeSpan.FromSeconds(0);
        //    animation10.RepeatBehavior = new RepeatBehavior(1);
        //    animation10.Duration = TimeSpan.FromSeconds(3);
        //    Storyboard.SetTarget(animation10, list[4]);
        //    Storyboard.SetTargetProperty(animation10, "(UIElement.Projection).(PlaneProjection.RotationY)");
        //   // rotationback5.Children.Clear();
        //    rotationback5.Children.Add(animation10);

        //    DoubleAnimation animation12 = new DoubleAnimation();
        //    animation12.From = 180;
        //    animation12.To = 360;
        //    animation12.BeginTime = TimeSpan.FromSeconds(0);
        //    animation12.RepeatBehavior = new RepeatBehavior(1);
        //    animation12.Duration = TimeSpan.FromSeconds(3);
        //    Storyboard.SetTarget(animation12, list[5]);
        //    Storyboard.SetTargetProperty(animation12, "(UIElement.Projection).(PlaneProjection.RotationY)");
        //  //rotationback6.Children.Clear();
        //    rotationback6.Children.Add(animation12);

        //    DoubleAnimation animation14 = new DoubleAnimation();
        //    animation14.From = 180;
        //    animation14.To = 360;
        //    animation14.BeginTime = TimeSpan.FromSeconds(0);
        //    animation14.RepeatBehavior = new RepeatBehavior(1);
        //    animation14.Duration = TimeSpan.FromSeconds(3);
        //    Storyboard.SetTarget(animation14, list[6]);
        //    Storyboard.SetTargetProperty(animation14, "(UIElement.Projection).(PlaneProjection.RotationY)");
        //  //rotationback7.Children.Clear();
        //    rotationback7.Children.Add(animation14);

        //    DoubleAnimation animation16 = new DoubleAnimation();
        //    animation16.From = 180;
        //    animation16.To = 360;
        //    animation16.BeginTime = TimeSpan.FromSeconds(0);
        //    animation16.RepeatBehavior = new RepeatBehavior(1);
        //    animation16.Duration = TimeSpan.FromSeconds(3);
        //    Storyboard.SetTarget(animation16, list[7]);
        //    Storyboard.SetTargetProperty(animation16, "(UIElement.Projection).(PlaneProjection.RotationY)");
        //   //rotationback8.Children.Clear();
        //    rotationback8.Children.Add(animation16);
        //}

        private void TimerTick(object sender, object e)
        {
            TimeDate.Text = DateTime.Now.ToString("HH:mm");
            TodaysDate.Text = DateTime.Today.ToString("yyyy-MM-dd");
        }

        //private void Animation()
        //{
        //    rotationfront1.Begin();
        //    rotationback1.Begin();
        //}

        //private void Fade()
        //{
        //    //BackImg1.Opacity = 0;
        //    //BackImg2.Opacity = 0;
        //    //BackImg3.Opacity = 0;
        //    //BackImg4.Opacity = 0;
        //    //BackImg5.Opacity = 0;
        //    //BackImg6.Opacity = 0;
        //    //BackImg7.Opacity = 0;
        //    //BackImg8.Opacity = 0;

        //    //grid1.Opacity = 0;
        //    //grid2.Opacity = 0;
        //    //grid3.Opacity = 0;
        //    //grid4.Opacity = 0;
        //    //grid5.Opacity = 0;
        //    //grid6.Opacity = 0;
        //    //grid7.Opacity = 0;
        //    //grid8.Opacity = 0;

        //    // bild1.Fade(duration: 1000, delay: 0, value: 0).Start();
        //    //Imgbox2.Fade(duration: 1000, delay: 0, value: 0).Start();
        //    //Imgbox3.Fade(duration: 1000, delay: 0, value: 0).Start();
        //    //Imgbox4.Fade(duration: 1000, delay: 0, value: 0).Start();
        //    //Imgbox5.Fade(duration: 1000, delay: 0, value: 0).Start();
        //    //Imgbox6.Fade(duration: 1000, delay: 0, value: 0).Start();
        //    //Imgbox7.Fade(duration: 1000, delay: 0, value: 0).Start();
        //    //Imgbox8.Fade(duration: 1000, delay: 0, value: 0).Start();

        //    //grid1.Fade(duration: 4000, delay: 3000, value: 1).Start();
        //    //grid1.Fade(duration: 4000, delay: 3000, value: 1).Start();
        //    //grid2.Fade(duration: 4000, delay: 3000, value: 1).Start();
        //    //grid3.Fade(duration: 4000, delay: 3000, value: 1).Start();
        //    //grid4.Fade(duration: 4000, delay: 3000, value: 1).Start();
        //    //grid5.Fade(duration: 4000, delay: 3000, value: 1).Start();
        //    //grid6.Fade(duration: 4000, delay: 3000, value: 1).Start();
        //    //grid7.Fade(duration: 4000, delay: 3000, value: 1).Start();
        //    //grid8.Fade(duration: 4000, delay: 3000, value: 1).Start();

        //    //BackImg1.Fade(duration: 4000, delay: 1200, value: 1).Start();
        //    //BackImg2.Fade(duration: 4000, delay: 1200, value: 1).Start();
        //    //BackImg3.Fade(duration: 4000, delay: 1200, value: 1).Start();
        //    //BackImg4.Fade(duration: 4000, delay: 1200, value: 1).Start();
        //    //BackImg5.Fade(duration: 4000, delay: 1200, value: 1).Start();
        //    //BackImg6.Fade(duration: 4000, delay: 1200, value: 1).Start();
        //    //BackImg7.Fade(duration: 4000, delay: 1200, value: 1).Start();
        //    //BackImg8.Fade(duration: 4000, delay: 1200, value: 1).Start();

        //    //rotationback8.Begin();
        //}

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            attributes.Clear();
            //Fade();
            //Animation();
        }

        private void FlipCardConditions()
        {
            //    //if (Attributes.Count < 8)
            //    //{
            //    //    rotationback1.Stop();
            //    //    rotationfront1.Stop();
            //    //}

            //    //while (Attributes.Count > 8)
            //    //{

            //    //    try
            //    //    {
            //    //        rotationback1.Stop();
            //    //        rotationfront1.Stop();
            //    //        DispatcherTimer tm8 = new DispatcherTimer();
            //    //        tm8.Interval = TimeSpan.FromSeconds(10);
            //    //        tm8.Tick += (sender, args) =>
            //    //        {
            //    //            rotationback1.Begin();
            //    //            rotationfront1.Begin();

            //    //            BackImg1.Opacity = 0;

            //    //            grid1.Opacity = 0;

            //    //            Imgbox1.Fade(duration: 1000, delay: 0, value: 0).Start();

            //    //            grid1.Fade(duration: 4000, delay: 3000, value: 1).Start();

            //    //            BackImg1.Fade(duration: 4000, delay: 1200, value: 1).Start();

            //    //            tm8.Stop();
            //    //        };
            //    //        tm8.Start();
            //    //    }
            //    //    finally
            //    //    {
            //    //        rotationback1.Stop();
            //    //        rotationfront1.Stop();
            //    //    }
            //    //}
        }

        public void StartTimer(int IntervalSec)
        {
            //    //CmdBar.ClosedDisplayMode = AppBarClosedDisplayMode.Compact;
            //    //if (IntervalSec > 0)
            //    //{
            //    //    DisTimer.Interval = new TimeSpan(0, 0, IntervalSec);
            //    //    DisTimer.Tick += TimerOnTick;
            //    //    CmdBar.ClosedDisplayMode = AppBarClosedDisplayMode.Hidden;
            //    //    DisTimer.Start();
            //    //}
            //    //else
            //    //{
            //    //    CmdBar.ClosedDisplayMode = AppBarClosedDisplayMode.Hidden;
            //    //    DisTimer.Stop();
            //    //    _allowexicution = false;
            //    //}
        }

        //private void FlipCardConditions()
        //{
        //    if (Attributes.Count < 8)
        //    {
        //        rotationback1.Stop();
        //        rotationfront1.Stop();
        //    }

        //    while (Attributes.Count > 8)
        //    {

        //        try
        //        {
        //            rotationback1.Stop();
        //            rotationfront1.Stop();
        //            DispatcherTimer tm8 = new DispatcherTimer();
        //            tm8.Interval = TimeSpan.FromSeconds(10);
        //            tm8.Tick += (sender, args) =>
        //            {
        //                rotationback1.Begin();
        //                rotationfront1.Begin();

        //                BackImg1.Opacity = 0;

        //                grid1.Opacity = 0;

        //                Imgbox1.Fade(duration: 1000, delay: 0, value: 0).Start();

        //                grid1.Fade(duration: 4000, delay: 3000, value: 1).Start();

        //                BackImg1.Fade(duration: 4000, delay: 1200, value: 1).Start();

        //                tm8.Stop();
        //            };
        //            tm8.Start();
        //        }
        //        finally
        //        {
        //            rotationback1.Stop();
        //            rotationfront1.Stop();
        //        }
        //    }
        //}

        //public void StartTimer(int IntervalSec)
        //{
        //    CmdBar.ClosedDisplayMode = AppBarClosedDisplayMode.Compact;
        //    if (IntervalSec > 0)
        //    {
        //        DisTimer.Interval = new TimeSpan(0, 0, IntervalSec);
        //        DisTimer.Tick += TimerOnTick;
        //        CmdBar.ClosedDisplayMode = AppBarClosedDisplayMode.Hidden;
        //        DisTimer.Start();
        //    }
        //    else
        //    {
        //        CmdBar.ClosedDisplayMode = AppBarClosedDisplayMode.Hidden;
        //        DisTimer.Stop();
        //        _allowexicution = false;
        //    }
        //}

        public void TimerOnTick(object sender, object o)
        {
            SpanTime = SpanTime.Add(DisTimer.Interval);
        }

        public void OnPointerMoved(object Sender, PointerRoutedEventArgs e)
        {
            ////StartTimer(5);
            //CmdBar.ClosedDisplayMode = AppBarClosedDisplayMode.Compact;
            //DispatcherTimer ButtonTimer = new DispatcherTimer();
            //ButtonTimer.Interval = TimeSpan.FromSeconds(5);
            //ButtonTimer.Tick += (sender, args) =>
            //{
            //    CmdBar.ClosedDisplayMode = AppBarClosedDisplayMode.Hidden;
            //};
            //ButtonTimer.Start();
        }

        private void SettingsButtonAppBar_Click(object sender, RoutedEventArgs e)
        {
            SettingsGrid.Visibility = Visibility.Visible;
            GeneralSettingsGrid.Visibility = Visibility.Visible;
            ApiSettingsGrid.Visibility = Visibility.Collapsed;
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void LeaveSettingsMenu_Click(object sender, RoutedEventArgs e)
        {
            SettingsGrid.Visibility = Visibility.Collapsed;
        }

        private void ApiButton_Click(object sender, RoutedEventArgs e)
        {
            ApiSettingsGrid.Visibility = Visibility.Visible;
            GeneralSettingsGrid.Visibility = Visibility.Collapsed;
        }

        private void GeneralSettingsButton_Click(object sender, RoutedEventArgs e)
        {
            GeneralSettingsGrid.Visibility = Visibility.Visible;
            ApiSettingsGrid.Visibility = Visibility.Collapsed;
        }

        private void ContentArea_Tapped(object Sender, TappedRoutedEventArgs e)
        {
            CmdBar.ClosedDisplayMode = AppBarClosedDisplayMode.Compact;
            DispatcherTimer ButtonTimer = new DispatcherTimer();
            ButtonTimer.Interval = TimeSpan.FromSeconds(20);
            ButtonTimer.Tick += (sender, args) =>
            {
                CmdBar.ClosedDisplayMode = AppBarClosedDisplayMode.Hidden;
                ButtonTimer.Stop();
            };
            ButtonTimer.Start();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {

        }

        //public void YellowindIcatorColorToGreenIndicatorColor()
        //{
        //    LinearGradientBrush GreenBrush = (LinearGradientBrush)Resources["GreenLinearBrush"];
        //    LinearGradientBrush YellowBrush = (LinearGradientBrush)Resources["YellowLinearBrush"];
        //    RectangelGrid2.Fill = YellowBrush;
        //}

        //public void YellowindIcatorColorToGreenIndicatorColor()
        //{
        //    LinearGradientBrush GreenBrush = (LinearGradientBrush)Resources["GreenLinearBrush"];
        //    LinearGradientBrush YellowBrush = (LinearGradientBrush)Resources["YellowLinearBrush"];
        //    RectangelGrid2.Fill = YellowBrush;
        //    DispatcherTimer ColorTimer2 = new DispatcherTimer();
        //    ColorTimer2.Interval = TimeSpan.FromMinutes(45);
        //    ColorTimer2.Tick += (Zender, Args) =>
        //    {
        //        RectangelGrid2.Fill = GreenBrush;
        //        ColorTimer2.Stop();
        //    };
        //    ColorTimer2.Start();
        //}

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            attributes.Add(new Attributes { RoomID = 1, RoomName = "Rum 1", Projector = true, Wboard = false, Tv = false, Wifi = true, Seats = 5, Note = "Lorem ipsum dolor sit amet, co" });
        }


        private void Page_Loaded(object sender, RoutedEventArgs e)
        {


        }
    }
}
