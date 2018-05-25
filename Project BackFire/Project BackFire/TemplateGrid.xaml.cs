using Microsoft.Toolkit.Uwp.UI.Animations;
using Newtonsoft.Json;
using Project_BackFire.Models;
using Project_BackFire.Views;
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
            InitializeComponent();
            Rooms = new ObservableCollection<Room>();

            GreenBrush = (LinearGradientBrush)Resources["GreenLinearBrush"];
            YellowBrush = (LinearGradientBrush)Resources["YellowLinearBrush"];
            RedBrush = (LinearGradientBrush)Resources["RedLinearBrush"];

            Easteregg();
            OnBooked();
            FlipCardConditions();
            //FadeIn();
        }

        public void OnBooked()
        {
            foreach (Room Rooms in Rooms)
            {
                switch (Rooms.Status)
                {
                    case 0:
                        StatusColor.Fill = GreenBrush;
                        CompanyNote.Visibility = Visibility.Collapsed;
                        break;
                    case 1:
                        StatusColor.Fill = YellowBrush;
                        CompanyNote.Visibility = Visibility.Visible;
                        break;
                    case 2:
                        StatusColor.Fill = RedBrush;
                        CompanyNote.Visibility = Visibility.Visible;
                        break;
                }
            }
   
            foreach (Room Rooms in Rooms)
            {
                switch (Rooms.Status <= 7)
                {
                    case true:
                        StatusColor.Fill = RedBrush;
                        break;

                    case false:
                        StatusColor.Fill = GreenBrush;
                        break;
                }
            }
        }

        public void RedIndicatorColorToYellowIndicatorColor()
        {
            StatusColor.Fill = GreenBrush;
            DispatcherTimer ColorTimer = new DispatcherTimer();
            ColorTimer.Interval = TimeSpan.FromSeconds(7);
            ColorTimer.Tick += async (Sender, args) =>
            {
                await StatusColor.Fade(duration: 1000, delay: 0, value: 0).StartAsync();
                StatusColor.Fill = RedBrush;
                await StatusColor.Fade(duration: 1200, delay: 0, value: 1).StartAsync();

                YellowindIcatorColorToGreenIndicatorColor();
                ColorTimer.Stop();
            };
            ColorTimer.Start();
        }

        public void YellowindIcatorColorToGreenIndicatorColor()
        {
            DispatcherTimer ColorTimer2 = new DispatcherTimer();
            ColorTimer2.Interval = TimeSpan.FromSeconds(7);
            ColorTimer2.Tick += async (Zender, Args) =>
            {
                await StatusColor.Fade(duration: 1000, delay: 0, value: 0).StartAsync();
                StatusColor.Fill = YellowBrush;
                await StatusColor.Fade(duration: 1200, delay: 0, value: 1).StartAsync();

                red2green();
                ColorTimer2.Stop();
            };
            ColorTimer2.Start();
        }

        public void red2green()
        {
            DispatcherTimer ColorTimer = new DispatcherTimer();
            ColorTimer.Interval = TimeSpan.FromSeconds(7);
            ColorTimer.Tick += async (Sender, args) =>
            {
                await StatusColor.Fade(duration: 1000, delay: 0, value: 0).StartAsync();
                StatusColor.Fill = GreenBrush;
                await StatusColor.Fade(duration: 1200, delay: 0, value: 1).StartAsync();

                ColorTimer.Stop();
            };
            ColorTimer.Start();
        }

        public void FlipCardConditions()
        {
            RedIndicatorColorToYellowIndicatorColor();
        }

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
