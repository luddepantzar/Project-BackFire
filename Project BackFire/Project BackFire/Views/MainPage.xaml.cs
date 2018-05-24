using System;
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
using Windows.UI.Xaml.Shapes;


namespace Project_BackFire.Views
{
    public partial class Main : Page
    {
        public ObservableCollection<Room> Rooms;

        public DispatcherTimer DisTimer = new DispatcherTimer();
        private DispatcherTimer Timer {get; set;}

        private LinearGradientBrush GreenBrush;
        private LinearGradientBrush YellowBrush;
        private LinearGradientBrush RedBrush;

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

            Rooms = new ObservableCollection<Room>();

            CmdBar.ClosedDisplayMode = AppBarClosedDisplayMode.Hidden;
            Timer = new DispatcherTimer() { Interval = TimeSpan.FromSeconds(5) };
            Timer.Tick += (sender, args) => {
                CmdBar.ClosedDisplayMode = AppBarClosedDisplayMode.Hidden;
                SettingsGrid.Visibility = Visibility.Collapsed;
                Timer.Stop();
            };

            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.FullScreen;
            GreenBrush = (LinearGradientBrush)Resources["GreenLinearBrush"];
            YellowBrush = (LinearGradientBrush)Resources["YellowLinearBrush"];
            RedBrush = (LinearGradientBrush)Resources["RedLinearBrush"];


            ApplicationDataContainer localSettings =
            ApplicationData.Current.LocalSettings;
            StorageFolder localFolder =
            ApplicationData.Current.LocalFolder;

            ApplicationDataCompositeValue composite =
           (ApplicationDataCompositeValue)localSettings.Values["exampleCompositeSetting"];


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
            ApplicationDataContainer localSettings =
            ApplicationData.Current.LocalSettings;
            StorageFolder localFolder =
            ApplicationData.Current.LocalFolder;


            ApplicationDataCompositeValue composite =
            new ApplicationDataCompositeValue();
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

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Rooms.Clear();
            //Fade();
            //Animation();
        }

        public void OnPointerMoved(object Sender, PointerRoutedEventArgs e)
        {
            Timer.Stop();
            CmdBar.ClosedDisplayMode = AppBarClosedDisplayMode.Compact;
            Timer.Start();
        }

        private void SettingsButtonAppBar_Click(object sender, RoutedEventArgs e)
        {
            SettingsGrid.Visibility = Visibility.Visible;
            GeneralSettingsGrid.Visibility = Visibility.Visible;
            ApiSettingsGrid.Visibility = Visibility.Collapsed;
            AboutSettingsGrid.Visibility = Visibility.Collapsed;

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
            AboutSettingsGrid.Visibility = Visibility.Collapsed;

        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            ApiSettingsGrid.Visibility = Visibility.Collapsed;
            GeneralSettingsGrid.Visibility = Visibility.Collapsed;
            AboutSettingsGrid.Visibility = Visibility.Visible;
        }

        private void GeneralSettingsButton_Click(object sender, RoutedEventArgs e)
        {
            GeneralSettingsGrid.Visibility = Visibility.Visible;
            ApiSettingsGrid.Visibility = Visibility.Collapsed;
            AboutSettingsGrid.Visibility = Visibility.Collapsed;

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
            switch (Rooms.Count)
            {
                case 1:
                    {
                        GridView1.Height = 450;
                        GridView1.Width = 880;
                        break;
                    }
                case  2 :
                    {
                        GridView1.Height = 450;
                        GridView1.Width = 880;
                        break;
                    }
                case 3:
                    {
                        GridView1.Height = 450;
                        GridView1.Width = 1305;
                        break;
                    }
                case 4:
                    {
                        GridView1.Height = 450;
                        GridView1.Width = 1740;
                        break;
                    }
                case 5:
                    {
                        //Rooms.RemoveAt(0);
                        //DispatcherTimer tmer = new DispatcherTimer();
                        //tmer.Interval = TimeSpan.FromSeconds(3);
                        //tmer.Tick += (Sender, args) =>
                        //{
                        //};
                     
                        goto case 6;
                    }
                case 6:
                    {
                        GridView1.Height = 835;
                        GridView1.Width = 1305;
                        break;
                    }
                case 7:
                    {
                        //Rooms.RemoveAt(0);
                        //DispatcherTimer tmer = new DispatcherTimer();
                        //tmer.Interval = TimeSpan.FromSeconds(3);
                        //tmer.Tick += (Sender, args) =>
                        //{
                        //    Rooms.Add(new Room { RoomID = 1, RoomName = "Rum 1 Main", FrontImage = "ms-appx:///Images/c1.jpeg", Projector = Visibility.Visible, Wboard = Visibility.Collapsed, Tv = Visibility.Collapsed, Wifi = Visibility.Visible, Seats = 5, Status = 0, Note = "Lorem ipsum dolor sit amet, co" });
                        //};
                        //GridView1.Height = 835;
                        //GridView1.Width = 1305;
                        goto case 8;
                    }
                case 8:
                    {
                        GridView1.Height = 835;
                        GridView1.Width = 1740;
                        break;
                    }
            }

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
