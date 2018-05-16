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
        //public Models.Attributes Attributes {  get { return this.DataContext as Models.Attributes; } }

        public List<Attributes> attributes;
        private LinearGradientBrush GreenBrush;
        private LinearGradientBrush YellowBrush;
        private LinearGradientBrush RedBrush;

        public TemplateGrid()
        {
            InitializeComponent();
            GreenBrush = (LinearGradientBrush)Resources["GreenLinearBrush"];
            YellowBrush = (LinearGradientBrush)Resources["YellowLinearBrush"];
            RedBrush = (LinearGradientBrush)Resources["RedLinearBrush"];
            //this.DataContextChanged += (s, e) => Bindings.Update();
            SwitchAttributes();
            OnBooked();
        }

        public void SwitchAttributes()
        {
            

            //Attributes c1 = new Attributes
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

            //var FirstCard = attributes.IndexOf( attributes.Where(x => x.RoomID == 3).FirstOrDefault() );
           ////foreach(Attributes attribute in attributes)
           //// {
           ////     switch(attribute.Status)
           ////     {
           ////         case 0:
           ////             StatusColor.Fill = GreenBrush;
           ////             break;
           ////         case 1:
           ////             StatusColor.Fill = YellowBrush;
           ////             break;
           ////         case 2:
           ////             StatusColor.Fill = RedBrush;
           ////             break;
           ////     }
           //// }
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
