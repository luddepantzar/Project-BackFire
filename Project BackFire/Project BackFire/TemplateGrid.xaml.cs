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

<<<<<<< HEAD
        public ObservableCollection<Room> Rooms;
=======
        public List<Attributes> attributes;
>>>>>>> 84a15fe2d8c273fcce1a5c05f5ccb952af8a3cd7

        public TemplateGrid()
        {
            InitializeComponent();
            //this.DataContextChanged += (s, e) => Bindings.Update();
            SwitchRooms();
            OnBooked();
        }

        public void SwitchRooms()
        {
<<<<<<< HEAD
            Rooms = new ObservableCollection<Room>();
=======
            attributes = new List<Attributes>();
>>>>>>> 84a15fe2d8c273fcce1a5c05f5ccb952af8a3cd7



            var status = Rooms.Any(p => p.RoomID <= 1);


            switch (status)
            {
                case true:
                    MainImage.Width = 500;
                    MainImage.Height = 500;
                    break;

                case false:

                    break;

            }



            //Rooms c1 = new Rooms
            //{
            //    RoomID = 10,
            //    RoomName = "Rum 10",
            //    Projector = true,
            //    Wboard = false,
            //    Tv = false,
            //    Wifi = true,
            //    Seats = 5,
            //    Note = "Lorem ipsum dolor sit amet, co"
            //};
            //switch (c1.Projector)
            //{
            //    case false:
            //        {
            //            CheckProj.Visibility = Visibility.Collapsed;
            //            ErrProj.Visibility = Visibility.Visible;
            //            break;
            //        }
            //    case true:
            //        {
            //            ErrProj.Visibility = Visibility.Collapsed;
            //            CheckProj.Visibility = Visibility.Visible;
            //            break;
            //        }
            //}
            //switch (c1.Wboard)
            //{
            //    case false:
            //        {
            //            CheckWhiteboard.Visibility = Visibility.Collapsed;
            //            ErrWboard.Visibility = Visibility.Visible;
            //            break;
            //        }

            //    case true:
            //        {
            //            CheckWhiteboard.Visibility = Visibility.Visible;
            //            ErrWboard.Visibility = Visibility.Collapsed;
            //            break;
            //        }
            //}
            //switch (c1.Tv)
            //{
            //    case false:
            //        {
            //            CheckTV.Visibility = Visibility.Collapsed;
            //            ErrTv.Visibility = Visibility.Visible;
            //            break;
            //        }

            //    case true:
            //        {
            //            CheckTV.Visibility = Visibility.Visible;
            //            ErrTv.Visibility = Visibility.Collapsed;
            //            break;
            //        }
            //}
            //switch (c1.Wifi)
            //{
            //    case false:
            //        {
            //            CheckWifi.Visibility = Visibility.Collapsed;
            //            ErrWifi.Visibility = Visibility.Visible;
            //            break;
            //        }
            //    case true:
            //        {
            //            CheckWifi.Visibility = Visibility.Visible;
            //            ErrWifi.Visibility = Visibility.Collapsed;
            //            break;
            //        }
            //}
        }

        private void OnBooked()
        {
            LinearGradientBrush RedBrush = (LinearGradientBrush)Resources["RedLinearBrush"];
<<<<<<< HEAD
            var FirstCard = Rooms.IndexOf(new Room { RoomID = 1 });
=======
<<<<<<< HEAD

            //var FirstCard = attributes.IndexOf( attributes.Where(x => x.RoomID == 3).FirstOrDefault() );
            List<Attributes> attrib = new List<Attributes>();
            var FirstCard = attrib.FindAll(x => x.RoomID == 0);
            
            switch(FirstCard.Count)
            {
                case 1:
                    {
                        StatusColor.Fill = RedBrush;
                        break;
                    }

                default:
                    {
                        CheckSeats.Text = FirstCard.Count.ToString();
                        break;
                    }
            }
=======
            var FirstCard = attributes.IndexOf(new Attributes { RoomID = 1 });
>>>>>>> 84a15fe2d8c273fcce1a5c05f5ccb952af8a3cd7
            StatusColor.Fill = RedBrush;
>>>>>>> 38530c03acf03985fa3bf85415134699274921ad

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
        {
            LinearGradientBrush GreenBrush = (LinearGradientBrush)Resources["GreenLinearBrush"];
            LinearGradientBrush YellowBrush = (LinearGradientBrush)Resources["YellowLinearBrush"];
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

    }
}
