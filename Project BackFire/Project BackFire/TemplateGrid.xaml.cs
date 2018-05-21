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
            this.InitializeComponent();
<<<<<<< HEAD


            Rooms = new ObservableCollection<Room>();
=======
=======
            InitializeComponent();
            Rooms = new ObservableCollection<Room>();
<<<<<<< HEAD
            Rooms.Add(new Room { RoomID = 1, RoomName = "Rum 1", FrontImage = "ms-appx:///Images/c1.jpeg", Projector = Visibility.Visible, Wboard = Visibility.Collapsed, Tv = Visibility.Collapsed, Wifi = Visibility.Visible, Seats = 5, Note = "Lorem ipsum dolor sit amet, co", Status = 0 });
            Rooms.Add(new Room { RoomID = 2, RoomName = "Rum 2", FrontImage = "ms-appx:///Images/c2.jpeg", Projector = Visibility.Collapsed, Wboard = Visibility.Visible, Tv = Visibility.Visible, Wifi = Visibility.Visible, Seats = 10, Status = 1, Note = "Lorem ipsum dolor sit amet, co" });
            //Rooms.Add(new Room { RoomID = 3, RoomName = "Rum 3", FrontImage = "ms-appx:///Images/c1.jpeg", Projector = Visibility.Collapsed, Wboard = Visibility.Collapsed, Tv = Visibility.Visible, Wifi = Visibility.Collapsed, Seats = 4, Status = 2, Note = "Lorem ipsum dolor sit amet, co" });
            //Rooms.Add(new Room { RoomID = 4, RoomName = "Rum 4", FrontImage = "ms-appx:///Images/c2.jpeg", Projector = Visibility.Visible, Wboard = Visibility.Visible, Tv = Visibility.Collapsed, Wifi = Visibility.Visible, Seats = 15, Status = 2, Note = "Lorem ipsum dolor sit amet, co" });
            //Rooms.Add(new Room { RoomID = 5, RoomName = "Rum 5", FrontImage = "ms-appx:///Images/c3.jpg", Projector = Visibility.Visible, Wboard = Visibility.Collapsed, Tv = Visibility.Collapsed, Wifi = Visibility.Visible, Seats = 7, Status = 1, Note = "Lorem ipsum dolor sit amet, co" });
            //Rooms.Add(new Room { RoomID = 6, RoomName = "Rum 6", FrontImage = "ms-appx:///Images/c2.jpeg", Projector = Visibility.Collapsed, Wboard = Visibility.Visible, Tv = Visibility.Visible, Wifi = Visibility.Collapsed, Seats = 22, Status = 0, Note = "Lorem ipsum dolor sit amet, co" });
            //Rooms.Add(new Room { RoomID = 7, RoomName = "Rum 7", FrontImage = "ms-appx:///Images/c3.jpg", Projector = Visibility.Collapsed, Wboard = Visibility.Collapsed, Tv = Visibility.Visible, Wifi = Visibility.Visible, Seats = 12, Status = 2, Note = "Lorem ipsum dolor sit amet, co" });
            //Rooms.Add(new Room { RoomID = 8, RoomName = "Rum 8", FrontImage = "ms-appx:///Images/c1.jpeg", Projector = Visibility.Visible, Wboard = Visibility.Visible, Tv = Visibility.Collapsed, Wifi = Visibility.Collapsed, Seats = 30, Status = 1, Note = "Lorem ipsum dolor sit amet, co" });
            //Rooms.Add(new Room { RoomID = 9, RoomName = "Rum 9", FrontImage = "ms-appx:///Images/c3.jpg", Projector = Visibility.Collapsed, Wboard = Visibility.Visible, Tv = Visibility.Collapsed, Wifi = Visibility.Visible, Seats = 25, Status = 2, Note = "Lorem ipsum dolor sit amet, co" });
            //Rooms.Add(new Room { RoomID = 10, RoomName = "Rum 9", FrontImage = "ms-appx:///Images/c3.jpg", Projector = Visibility.Collapsed, Wboard = Visibility.Visible, Tv = Visibility.Visible, Wifi = Visibility.Collapsed, Seats = 14, Status = 2, Note = "Lorem ipsum dolor sit amet, co" });
            //Rooms.Add(new Room { RoomID = 11, RoomName = "Rum 9", FrontImage = "ms-appx:///Images/c3.jpg", Projector = Visibility.Visible, Wboard = Visibility.Collapsed, Tv = Visibility.Visible, Wifi = Visibility.Visible, Seats = 16, Status = 2, Note = "Lorem ipsum dolor sit amet, co" });
            //Rooms.Add(new Room { RoomID = 12, RoomName = "Rum 9", FrontImage = "ms-appx:///Images/c3.jpg", Projector = Visibility.Collapsed, Wboard = Visibility.Visible, Tv = Visibility.Collapsed, Wifi = Visibility.Collapsed, Seats = 8, Status = 0, Note = "Lorem ipsum dolor sit amet, co" });
            //Rooms.Add(new Room { RoomID = 13, RoomName = "Rum 9", FrontImage = "ms-appx:///Images/c3.jpg", Projector = Visibility.Collapsed, Wboard = Visibility.Collapsed, Tv = Visibility.Visible, Wifi = Visibility.Collapsed, Seats = 11, Status = 1, Note = "Lorem ipsum dolor sit amet, co" });
            //Rooms.Add(new Room { RoomID = 14, RoomName = "Rum 9", FrontImage = "ms-appx:///Images/c3.jpg", Projector = Visibility.Visible, Wboard = Visibility.Visible, Tv = Visibility.Collapsed, Wifi = Visibility.Visible, Seats = 22, Status = 0, Note = "Lorem ipsum dolor sit amet, co" });
            //Rooms.Add(new Room { RoomID = 15, RoomName = "Rum 9", FrontImage = "ms-appx:///Images/c3.jpg", Projector = Visibility.Collapsed, Wboard = Visibility.Collapsed, Tv = Visibility.Visible, Wifi = Visibility.Collapsed, Seats = 43, Status = 0, Note = "Lorem ipsum dolor sit amet, co" });
            //Rooms.Add(new Room { RoomID = 16, RoomName = "Rum 9", FrontImage = "ms-appx:///Images/c3.jpg", Projector = Visibility.Visible, Wboard = Visibility.Collapsed, Tv = Visibility.Collapsed, Wifi = Visibility.Collapsed, Seats = 1, Status = 0, Note = "Lorem ipsum dolor sit amet, co" });

=======
>>>>>>> e994a3a028f0cf8403957ef07b3b41f13b3a3a47
>>>>>>> e8424875f8cd7b096ad9474a76a2e31d82d1553e
>>>>>>> 07f876db84ffe10edb713a815e64a33b8ccecfb8
            GreenBrush = (LinearGradientBrush)Resources["GreenLinearBrush"];
            YellowBrush = (LinearGradientBrush)Resources["YellowLinearBrush"];
            RedBrush = (LinearGradientBrush)Resources["RedLinearBrush"];

            // Easteregg();
            OnBooked();
<<<<<<< HEAD
            CardConditions();
=======
            //FlipCardConditions();
>>>>>>> e8424875f8cd7b096ad9474a76a2e31d82d1553e
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
<<<<<<< HEAD

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
=======
=======
            foreach (Room Rooms in Rooms)
            {
                switch (Rooms.Status)
                {
                    case 0:
                        StatusColor.Fill = GreenBrush;
                        break;
                    case 1:
                        YellowindIcatorColorToGreenIndicatorColor();
                        break;
                    case 2:
                        RedIndicatorColorToYellowIndicatorColor();
                        break;
                }

<<<<<<< HEAD
                //if (Rooms.Status == 0)
                //{
                //    StatusColor.Fill = GreenBrush;
                //}
                //else if (Rooms.Status == 1)
                //{
                //    StatusColor.Fill = YellowBrush;
                //}
                //else if(Rooms.Status == 2)
                //{
                //    StatusColor.Fill = RedBrush;
                //}
            }
        }
>>>>>>> 07f876db84ffe10edb713a815e64a33b8ccecfb8

        public void RedIndicatorColorToYellowIndicatorColor()
        {
            StatusColor.Fill = RedBrush;
            DispatcherTimer ColorTimer = new DispatcherTimer();
            ColorTimer.Interval = TimeSpan.FromSeconds(7);
            ColorTimer.Tick += (Sender, args) =>
            {
                YellowindIcatorColorToGreenIndicatorColor();
                ColorTimer.Stop();
            };
            ColorTimer.Start();
        }

        public void YellowindIcatorColorToGreenIndicatorColor()
=======
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
<<<<<<< HEAD
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


=======
>>>>>>> e994a3a028f0cf8403957ef07b3b41f13b3a3a47
>>>>>>> e8424875f8cd7b096ad9474a76a2e31d82d1553e
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

        public void CardConditions()
        {
            if (Rooms.Count > 8)
            {
<<<<<<< HEAD
                StatusColor.Fill = GreenBrush;
                ColorTimer2.Stop();
            };
            ColorTimer2.Start();
        }
        //public void FlipCardConditions()
        //{
        //    MainGrid.Opacity = 1;
        //    MainGrid.Fade(duration: 1000, delay: 4000, value: 0).Start();
        //    MainGrid.Fade(duration: 1000, delay: 10000, value: 1).Start();
        //}
=======
                MainGrid.Fade(duration: 1000, delay: 2000, value: 0).Start();
                StatusColor.Fill = RedBrush;

                DispatcherTimer FadeTimer = new DispatcherTimer();
                FadeTimer.Interval = TimeSpan.FromSeconds(3);
                FadeTimer.Tick += (sender, args) =>
                {
                    var index0 = Rooms.Where(p => p.RoomID == 1);
                    var index1 = Rooms.Where(p => p.RoomID == 2);
                    var index2 = Rooms.Where(p => p.RoomID == 3);

                    foreach (Room Rooms in Rooms)
                    {
                        switch (Rooms.RoomID)
                        {
                            case 2:
                                {
                                    StatusColor.Fill = GreenBrush;
                                    break;
                                }

                            case 1:
                                {
                                    StatusColor.Fill = YellowBrush;
                                    break;
                                }
                        }
                    }
                    MainGrid.Fade(duration: 1000, delay: 2000, value: 1).Start();
                };
                FadeTimer.Start();
            }

            switch(Rooms.Count)
            {
                case 2:
                    {
                        MainImage.Width = 550;
                        MainImage.Height = 500;
                        MainBorder.Width = 550;
                        MainBorder.Height = 500;
                        MainGrid.Width = 850;
                        MainGrid.Height = 800;
                        break;
                    }

                case 3:
                    {
                        MainImage.Width = 450;
                        MainImage.Height = 400;
                        MainBorder.Width = 450;
                        MainBorder.Height = 400;
                        MainGrid.Width = 570;
                        MainGrid.Height = 750;
                        break;
                    }

                case 4:
                    {
                        MainGrid.Width = 431;
                        MainGrid.Height = 799;
                        break;
                    }

                case 6:
                    {
                        MainImage.Width = 391;
                        MainImage.Height = 355;
                        MainBorder.Width = 391;
                        MainBorder.Height = 355;
                        MainGrid.Width = 570;
                        MainGrid.Height = 400;
                        break;
                    }

                case 8:
                    {
                        MainGrid.Height = 395;
                        MainGrid.Width = 431;
                        break;
                    }
            }
>>>>>>> 07f876db84ffe10edb713a815e64a33b8ccecfb8
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
