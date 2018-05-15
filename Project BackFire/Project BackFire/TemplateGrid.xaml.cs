using Project_BackFire.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Project_BackFire
{


    public sealed partial class TemplateGrid : UserControl
    {
        //public Models.Attributes Attributes {  get { return this.DataContext as Models.Attributes; } }

        public ObservableCollection<Attributes> attributes;

        public TemplateGrid()
        {
            this.InitializeComponent();

            //this.DataContextChanged += (s, e) => Bindings.Update();

            SwitchAttributes();
        }

        public void SwitchAttributes()
        {

            attributes = new ObservableCollection<Attributes>();

            Attributes c1 = new Attributes
            {
                RoomID = 10,
                RoomName = "Rum 10",
                Projector = true,
                Wboard = false,
                Tv = false,
                Wifi = true,
                Seats = 5,
                Note = "Lorem ipsum dolor sit amet, co"
            };

            switch (c1.Projector)
            {
                case false:
                    {
                        CheckProj.Visibility = Visibility.Collapsed;
                        ErrProj.Visibility = Visibility.Visible;
                        break;
                    }
                case true:
                    {
                        ErrProj.Visibility = Visibility.Collapsed;
                        CheckProj.Visibility = Visibility.Visible;
                        break;
                    }

                default:
                    break;
            }

            switch (c1.Wboard)
            {
                case false:
                    {
                        CheckWhiteboard.Visibility = Visibility.Collapsed;
                        ErrWboard.Visibility = Visibility.Visible;
                        break;
                    }

                case true:
                    {
                        CheckWhiteboard.Visibility = Visibility.Visible;
                        ErrWboard.Visibility = Visibility.Collapsed;
                        break;
                    }
            }

            switch (c1.Tv)
            {
                case false:
                    {
                        CheckTV.Visibility = Visibility.Collapsed;
                        ErrTv.Visibility = Visibility.Visible;
                        break;
                    }

                case true:
                    {
                        CheckTV.Visibility = Visibility.Visible;
                        ErrTv.Visibility = Visibility.Collapsed;
                        break;
                    }
            }

            switch (c1.Wifi)
            {
                case false:
                    {
                        CheckWifi.Visibility = Visibility.Collapsed;
                        ErrWifi.Visibility = Visibility.Visible;
                        break;
                    }

                case true:
                    {
                        CheckWifi.Visibility = Visibility.Visible;
                        ErrWifi.Visibility = Visibility.Collapsed;
                        break;
                    }



            }
        }

    }
}
