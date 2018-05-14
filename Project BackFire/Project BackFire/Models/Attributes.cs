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

namespace Project_BackFire.Models
{
    public class Attributes
    {
        public int RoomID { get; set; }
        public string RoomName { get; set; }
        public bool Projector { get; set; }
        public bool Wboard { get; set; }
        public string FrontImage { get; set; }
        public string BackImage { get; set; }
        public int Seats { get; set; }
        public bool Tv { get; set; }
        public bool Wifi { get; set; }
        public string CompanyNote { get; set; }
        public string Note { get; set; }
        public int Status { get; set; }
    }

   
}
