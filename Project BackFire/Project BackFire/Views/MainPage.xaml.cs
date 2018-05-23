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
using Windows.Storage;

namespace Project_BackFire.Views
{
    public partial class Main : Page
    {
        List<DependencyObject> List { get; set; }

        DependencyObject ImageArray { get; set; }

        public ObservableCollection<Room> Rooms;

        public DispatcherTimer DisTimer = new DispatcherTimer();

        private TimeSpan SpanTime;

        //public Image MainImage
        //{
        //    get { return MainImage; }
        //}
        //public Border MainBorder
        //{
        //    get { return MainBorder; }
        //}
        //public Grid MainGrid
        //{
        //    get { return MainGrid; }
        //}

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




            Rooms = new ObservableCollection<Room>();




            Windows.Storage.ApplicationDataContainer localSettings =
            Windows.Storage.ApplicationData.Current.LocalSettings;
            Windows.Storage.StorageFolder localFolder =
            Windows.Storage.ApplicationData.Current.LocalFolder;

            Windows.Storage.ApplicationDataCompositeValue composite =
           (Windows.Storage.ApplicationDataCompositeValue)localSettings.Values["exampleCompositeSetting"];


            if (composite == null)
            {
                // No data
            }
            else
            {
                GetnameExeo();
            }
        }



        private void Settings()
        {
            Windows.Storage.ApplicationDataContainer localSettings =
    Windows.Storage.ApplicationData.Current.LocalSettings;
            Windows.Storage.StorageFolder localFolder =
                Windows.Storage.ApplicationData.Current.LocalFolder;


            Windows.Storage.ApplicationDataCompositeValue composite =
    new Windows.Storage.ApplicationDataCompositeValue();
            composite["intVal"] = 1;
            composite["strVal"] = "string";

            localSettings.Values["exampleCompositeSetting"] = composite;
        }


       async private void RemoveSettings()
        {
            await ApplicationData.Current.ClearAsync();
        }



        async void GetnameExeo()
        {
            string url = "https://api.rumsbokning.nu/api/companies/aab96aa1-d8ca-4f74-8e35-ded190c38dd4";

            BitmapImage image = new BitmapImage(new Uri("https://api.rumsbokning.nu/api/companies/aab96aa1-d8ca-4f74-8e35-ded190c38dd4/image"));

            HttpClient client = new HttpClient();

            string response = await client.GetStringAsync(url);

            var data = JsonConvert.DeserializeObject<Rootobject>(response);

            Logo.Source = image;
            ContentArea.Background = (LinearGradientBrush)Resources["Test"];
            MenuBar.Background = (LinearGradientBrush)Resources["MenuTest"];
            ApiOutput.Text = "Välkommen " + data.name;

        }

        void GetDefault()
        {
            BitmapImage newlogo = new BitmapImage(new Uri("ms-appx:///Assets/test_logo_whitetxt.png"));
            Logo.Source = newlogo;
            ContentArea.Background = (LinearGradientBrush)Resources["MenuTest"];
            MenuBar.Background = (LinearGradientBrush)Resources["DefaultMenu"];
            ApiOutput.Text = "Default";
        }

        async void GetTestCompany()
        {
            string url = "https://api.rumsbokning.nu/api/companies/03ce761a-cd17-4eb3-9352-b5ba4ff4e303";

            HttpClient client = new HttpClient();

            string response = await client.GetStringAsync(url);

            var data = JsonConvert.DeserializeObject<Rootobject>(response);

            ContentArea.Background = (LinearGradientBrush)Resources["Company3"];
            MenuBar.Background = (LinearGradientBrush)Resources["MenuTest"];
            ApiOutput.Text = "Välkommen " + data.name;


        }

        public void InputApiBox()
        {
            ///*Just nu hämtas inte API-lösenordet från SQL databasen här*/
            ////string url = "https://api.rumsbokning.nu/api/companies/aab96aa1-d8ca-4f74-8e35-ded190c38dd4";

            ////HttpClient client = new HttpClient();

            ////string response = await client.GetStringAsync(url);

            ////var data = JsonConvert.DeserializeObject<Rootobject>(response);

            //BitmapImage newlogo = new BitmapImage(new Uri("ms-appx:///Assets/test_logo_whitetxt.png"));


            switch (ApiInput.Password)
            {
                case "1234":
                    {
                        GetnameExeo();
                        Settings();
                        break;
                    }
                case "0":
                    {
                        GetTestCompany();
                        break;
                    }
                case "Default":
                    GetDefault();
                    RemoveSettings();
                    break;
            }
        }

        private void ApiSubmitBut_Click(object sender, RoutedEventArgs e)
        {
            ApiContainer.Visibility = Visibility.Visible;
            InputApiBox();
        }


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
            Rooms.Clear();
            //Fade();
            //Animation();
        }

        private void FlipCardConditions()
        {
            //    //if (Rooms.Count < 8)
            //    //{
            //    //    rotationback1.Stop();
            //    //    rotationfront1.Stop();
            //    //}

            //    //while (Rooms.Count > 8)
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
        //    if (Rooms.Count < 8)
        //    {
        //        rotationback1.Stop();
        //        rotationfront1.Stop();
        //    }

        //    while (Rooms.Count > 8)
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

        private void btn3_Click(object sender, RoutedEventArgs e)
        {

            Random rnd = new Random();
            int val = rnd.Next(0, 9);

            switch (val)
            {
                case 1:
                    Rooms.Add(new Room { RoomID = 7, RoomName = "Rum 7 Main", FrontImage = "ms-appx:///Images/c5.jpeg", Projector = Visibility.Collapsed, Wboard = Visibility.Collapsed, Tv = Visibility.Visible, Wifi = Visibility.Visible, Seats = 12, Status = 3, Note = "Lorem ipsum dolor sit amet, co" });
                    break;
                case 2:
                    Rooms.Add(new Room { RoomID = 8, RoomName = "Rum 8 Main", FrontImage = "ms-appx:///Images/c3.jpg", Projector = Visibility.Visible, Wboard = Visibility.Visible, Tv = Visibility.Collapsed, Wifi = Visibility.Collapsed, Seats = 30, Status = 1, Note = "Lorem ipsum dolor sit amet, co" });
                    break;
                case 3:
                    Rooms.Add(new Room { RoomID = 3, RoomName = "Rum 3 Main", FrontImage = "ms-appx:///Images/c1.jpeg", Projector = Visibility.Collapsed, Wboard = Visibility.Collapsed, Tv = Visibility.Visible, Wifi = Visibility.Collapsed, Seats = 4, Status = 2, Note = "Lorem ipsum dolor sit amet, co" });
                    break;
                case 4:
                    Rooms.Add(new Room { RoomID = 6, RoomName = "Rum 6 Main", FrontImage = "ms-appx:///Images/c5.jpeg", Projector = Visibility.Collapsed, Wboard = Visibility.Visible, Tv = Visibility.Visible, Wifi = Visibility.Collapsed, Seats = 22, Status = 0, Note = "Lorem ipsum dolor sit amet, co" });
                    break;
                case 5:
                    Rooms.Add(new Room { RoomID = 1, RoomName = "Rum 1 Main", FrontImage = "ms-appx:///Images/c2.jpeg", Projector = Visibility.Visible, Wboard = Visibility.Collapsed, Tv = Visibility.Collapsed, Wifi = Visibility.Visible, Seats = 5, Status = 0, Note = "Lorem ipsum dolor sit amet, co" });
                    break;
                case 6:
                    Rooms.Add(new Room { RoomID = 4, RoomName = "Rum 4 Main", FrontImage = "ms-appx:///Images/c2.jpeg", Projector = Visibility.Visible, Wboard = Visibility.Visible, Tv = Visibility.Collapsed, Wifi = Visibility.Visible, Seats = 15, Status = 2, Note = "Lorem ipsum dolor sit amet, co" });
                    break;
                case 7:
                    Rooms.Add(new Room { RoomID = 2, RoomName = "Rum 2 Main", FrontImage = "ms-appx:///Images/c1.jpeg", Projector = Visibility.Collapsed, Wboard = Visibility.Visible, Tv = Visibility.Visible, Wifi = Visibility.Visible, Seats = 10, Status = 1, Note = "Lorem ipsum dolor sit amet, co" });
                    break;
                case 8:
                    Rooms.Add(new Room { RoomID = 5, RoomName = "Rum 5 Main", FrontImage = "ms-appx:///Images/c3.jpg", Projector = Visibility.Visible, Wboard = Visibility.Collapsed, Tv = Visibility.Collapsed, Wifi = Visibility.Visible, Seats = 7, Status = 3, Note = "Lorem ipsum dolor sit amet, co" });
                    break;
            }

            if (Rooms.Count == 9)
            {


            }

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {


        }

    }
}
