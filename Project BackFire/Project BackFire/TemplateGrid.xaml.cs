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
            InitializeComponent();
            GreenBrush = (LinearGradientBrush)Resources["GreenLinearBrush"];
            YellowBrush = (LinearGradientBrush)Resources["YellowLinearBrush"];
            RedBrush = (LinearGradientBrush)Resources["RedLinearBrush"];
            //this.DataContextChanged += (s, e) => Bindings.Update();
           
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
