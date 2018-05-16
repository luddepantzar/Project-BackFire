using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_BackFire.ViewModels;
using Project_BackFire.Views;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml;
using System.Collections.ObjectModel;

namespace Project_BackFire.Models
{
    public class Attributes
    {
        public int RoomID { get; set; }
        public string RoomName { get; set; }
        public string Projector { get; set; }
        public string Wboard { get; set; }
        public int Seats { get; set; }
        public string Tv { get; set; }
        public string Wifi { get; set; }
        public string FrontImage { get; set; }
        public string CompanyNote { get; set; }
        public string Note { get; set; }
        public int Status { get; set; }
    }


}
