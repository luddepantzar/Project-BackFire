using Microsoft.Toolkit.Uwp.UI.Animations;
using Newtonsoft.Json;
using Project_BackFire.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Project_BackFire
{
    public sealed partial class TemplateGrid : UserControl
    {
        //public Models.Rooms Rooms {  get { return this.DataContext as Models.Rooms; } }
        public ObservableCollection<Room> Rooms;

        private LinearGradientBrush GreenBrush;
        private LinearGradientBrush YellowBrush;
        private LinearGradientBrush RedBrush;
        public TemplateGrid()
        {
            this.InitializeComponent();


            Rooms = new ObservableCollection<Room>();
            GreenBrush = (LinearGradientBrush)Resources["GreenLinearBrush"];
            YellowBrush = (LinearGradientBrush)Resources["YellowLinearBrush"];
            RedBrush = (LinearGradientBrush)Resources["RedLinearBrush"];

            // Easteregg();
            OnBooked();
            //FlipCardConditions();
            //FadeIn();
        }

        //public void SwitchRooms()
        //{
        //    Rooms = new ObservableCollection<Room>();
        //    var status = Rooms.Any(p => p.RoomID <= 1);
        //    switch (status)
        //    {
        //        case true:
        //            MainImage.Width = 500;
        //            MainImage.Height = 500;
        //            break;
        //        case false:
        //            break;
        //    }
        //    //Rooms c1 = new Rooms
        //    //{
        //    //    RoomID = 10,
        //    //    RoomName = "Rum 10",
        //    //    Projector = true,
        //    //    Wboard = false,
        //    //    Tv = false,
        //    //    Wifi = true,
        //    //    Seats = 5,
        //    //    Note = "Lorem ipsum dolor sit amet, co"
        //    //};
        //    //switch (c1.Projector)
        //    //{
        //    //    case false:
        //    //        {
        //    //            CheckProj.Visibility = Visibility.Collapsed;
        //    //            ErrProj.Visibility = Visibility.Visible;
        //    //            break;
        //    //        }
        //    //    case true:
        //    //        {
        //    //            ErrProj.Visibility = Visibility.Collapsed;
        //    //            CheckProj.Visibility = Visibility.Visible;
        //    //            break;
        //    //        }
        //    //}
        //    //switch (c1.Wboard)
        //    //{
        //    //    case false:
        //    //        {
        //    //            CheckWhiteboard.Visibility = Visibility.Collapsed;
        //    //            ErrWboard.Visibility = Visibility.Visible;
        //    //            break;
        //    //        }
        //    //    case true:
        //    //        {
        //    //            CheckWhiteboard.Visibility = Visibility.Visible;
        //    //            ErrWboard.Visibility = Visibility.Collapsed;
        //    //            break;
        //    //        }
        //    //}
        //    //switch (c1.Tv)
        //    //{
        //    //    case false:
        //    //        {
        //    //            CheckTV.Visibility = Visibility.Collapsed;
        //    //            ErrTv.Visibility = Visibility.Visible;
        //    //            break;
        //    //        }
        //    //    case true:
        //    //        {
        //    //            CheckTV.Visibility = Visibility.Visible;
        //    //            ErrTv.Visibility = Visibility.Collapsed;
        //    //            break;
        //    //        }
        //    //}
        //    //switch (c1.Wifi)
        //    //{
        //    //    case false:
        //    //        {
        //    //            CheckWifi.Visibility = Visibility.Collapsed;
        //    //            ErrWifi.Visibility = Visibility.Visible;
        //    //            break;
        //    //        }
        //    //    case true:
        //    //        {
        //    //            CheckWifi.Visibility = Visibility.Visible;
        //    //            ErrWifi.Visibility = Visibility.Collapsed;
        //    //            break;
        //    //        }
        //    //}
        //}
        //public void SwitchRooms()
        //{
        //    Rooms = new ObservableCollection<Room>();
        //    var status = Rooms.Any(p => p.RoomID <= 1);
        //    switch (status)
        //    {
        //        case true:
        //            MainImage.Width = 500;
        //            MainImage.Height = 500;
        //            break;
        //        case false:
        //            break;
        //    }

        //    Rooms c1 = new Rooms
        //    {
        //        RoomID = 10,
        //        RoomName = "Rum 10",
        //        Projector = true,
        //        Wboard = false,
        //        Tv = false,
        //        Wifi = true,
        //        Seats = 5,
        //        Note = "Lorem ipsum dolor sit amet, co"
        //    };
        //    switch (c1.Projector)
        //    {
        //        case false:
        //            {
        //                CheckProj.Visibility = Visibility.Collapsed;
        //                ErrProj.Visibility = Visibility.Visible;
        //                break;
        //            }
        //        case true:
        //            {
        //                ErrProj.Visibility = Visibility.Collapsed;
        //                CheckProj.Visibility = Visibility.Visible;
        //                break;
        //            }
        //    }
        //    switch (c1.Wboard)
        //    {
        //        case false:
        //            {
        //                CheckWhiteboard.Visibility = Visibility.Collapsed;
        //                ErrWboard.Visibility = Visibility.Visible;
        //                break;
        //            }
        //        case true:
        //            {
        //                CheckWhiteboard.Visibility = Visibility.Visible;
        //                ErrWboard.Visibility = Visibility.Collapsed;
        //                break;
        //            }
        //    }
        //    switch (c1.Tv)
        //    {
        //        case false:
        //            {
        //                CheckTV.Visibility = Visibility.Collapsed;
        //                ErrTv.Visibility = Visibility.Visible;
        //                break;
        //            }
        //        case true:
        //            {
        //                CheckTV.Visibility = Visibility.Visible;
        //                ErrTv.Visibility = Visibility.Collapsed;
        //                break;
        //            }
        //    }
        //    switch (c1.Wifi)
        //    {
        //        case false:
        //            {
        //                CheckWifi.Visibility = Visibility.Collapsed;
        //                ErrWifi.Visibility = Visibility.Visible;
        //                break;
        //            }
        //        case true:
        //            {
        //                CheckWifi.Visibility = Visibility.Visible;
        //                ErrWifi.Visibility = Visibility.Collapsed;
        //                break;
        //            }
        //    }
        //}
        //private void EightRooms()
        //{
        //    foreach (Room attribute in Rooms)
        //    {
        //        switch (attribute.RoomID)
        //        {
        //            case 1:
        //                StatusColor.Fill = YellowBrush;
        //                break;
        //            default:
        //                break;
        //        }
        //    }
        //}

        public void OnBooked()
        {
            //foreach (Room rum in Rooms)
            //{
            //    if (rum.RoomID <= 7)
            //    {
            //        StatusColor.Fill = RedBrush;
            //    }
            //    else
            //    {
            //        StatusColor.Fill = YellowBrush;
            //    }

            //foreach (Room Rooms in Rooms)
            //{
            //    switch (Rooms.Status)
            //    {
            //        case 0:
            //            StatusColor.Fill = GreenBrush;
            //            break;
            //        case 1:
            //            StatusColor.Fill = YellowBrush;
            //            break;
            //        case 2:
            //            StatusColor.Fill = RedBrush;
            //            break;
            //    }
            //}

            //    StatusColor.Fill = RedBrush;
            //    DispatcherTimer ColorTimer = new DispatcherTimer();
            //    ColorTimer.Interval = TimeSpan.FromSeconds(7);
            //    ColorTimer.Tick += (Sender, args) =>
            //    {
            //        YellowindIcatorColorToGreenIndicatorColor();
            //        ColorTimer.Stop();
            //    };
            //    ColorTimer.Start();
            //}
        }

        public void YellowindIcatorColorToGreenIndicatorColor()
        {
            StatusColor.Fill = YellowBrush;
            DispatcherTimer ColorTimer2 = new DispatcherTimer();
            ColorTimer2.Interval = TimeSpan.FromSeconds(7);
            ColorTimer2.Tick += (Zender, Args) =>
            {
                StatusColor.Fill = GreenBrush;
                ColorTimer2.Stop();
            };
            ColorTimer2.Start();
        }
        //StatusColor.Fill = RedBrush;
        //DispatcherTimer ColorTimer = new DispatcherTimer();
        //ColorTimer.Interval = TimeSpan.FromSeconds(7);
        //ColorTimer.Tick += (Sender, args) =>
        //{
        //    YellowindIcatorColorToGreenIndicatorColor();
        //    ColorTimer.Stop();
        //};
        //ColorTimer.Start();



        public void FlipCardConditions()
        {

            //if (Rooms.Count > 8)
            //{
            //    StatusColor.Fill = GreenBrush;
            //    ColorTimer2.Stop();
            //};

            //ColorTimer2.Start();

            //MainGrid.Fade(duration: 1000, delay: 2000, value: 0).Start();
            //MainGrid.Rotate(value: 360.0f, centerX: 0.0f, centerY: 10.0f, duration: 3000, delay: 2000, easingType: EasingType.Back).Start();

            //DispatcherTimer FadeTimer = new DispatcherTimer();
            //FadeTimer.Interval = TimeSpan.FromSeconds(4);
            //FadeTimer.Tick += (sender, args) =>
            //{
            //    MainGrid.Fade(duration: 1000, delay: 2000, value: 1).Start();
            //    MainGrid.Rotate(value: 360.0f, centerX: 0.0f, centerY: 10.0f, duration: 3000, delay: 2000, easingType: EasingType.Back).Start();
            //};
            //FadeTimer.Start();


        }
        //public async void FadeIn()
        //{
        //    await MainGrid.Fade(duration: 1000, delay: 10000, value: 1).StartAsync();
        //}
        public void Easteregg()
        {
            Random rndm1 = new Random();
            int value1 = rndm1.Next(1, 120);

            DispatcherTimer EasterTimer1 = new DispatcherTimer();
            EasterTimer1.Interval = TimeSpan.FromSeconds(value1);
            EasterTimer1.Tick += (sender, args) =>
            {
                ProjIcon.Rotate(value: 360.0f, centerX: 0.0f, centerY: 10.0f, duration: 3500, delay: 0, easingType: EasingType.Bounce).Start();
            };
            EasterTimer1.Start();

            Random rndm2 = new Random();
            int value2 = rndm2.Next(10, 50);

            DispatcherTimer EasterTimer2 = new DispatcherTimer();
            EasterTimer2.Interval = TimeSpan.FromSeconds(value2);
            EasterTimer2.Tick += (sender, args) =>
            {
                WhiteboardIcon.Rotate(value: 360.0f, centerX: 0.0f, centerY: 10.0f, duration: 3500, delay: 0, easingType: EasingType.Back).Start();
            };
            EasterTimer2.Start();

            Random rndm3 = new Random();
            int value3 = rndm3.Next(10, 50);

            DispatcherTimer EasterTimer3 = new DispatcherTimer();
            EasterTimer3.Interval = TimeSpan.FromSeconds(value3);
            EasterTimer3.Tick += (sender, args) =>
            {
                Wifiicon.Rotate(value: 360.0f, centerX: 0.0f, centerY: 10.0f, duration: 3500, delay: 0, easingType: EasingType.Back).Start();
            };
            EasterTimer3.Start();

            Random rndm4 = new Random();
            int value4 = rndm4.Next(10, 50);

            DispatcherTimer EasterTimer4 = new DispatcherTimer();
            EasterTimer4.Interval = TimeSpan.FromSeconds(value4);
            EasterTimer4.Tick += (sender, args) =>
            {
                Tvicon.Rotate(value: 360.0f, centerX: 0.0f, centerY: 10.0f, duration: 3500, delay: 0, easingType: EasingType.Back).Start();
            };
            EasterTimer4.Start();
        }
    }
}
