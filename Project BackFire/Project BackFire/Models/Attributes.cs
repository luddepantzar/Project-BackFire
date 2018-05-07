using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_BackFire.ViewModels;
using Project_BackFire.Views;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace Project_BackFire.Models
{
    public class Attributes
    {
        public string RoomId { get; set; }
        public bool Projector { get; set; }
        public bool Wboard { get; set; }
        public string FrontImage { get; set; }
        public string BackImage { get; set; }
        public int Seats { get; set; }
<<<<<<< HEAD
       
=======
>>>>>>> d979cef0d5e445b69855b97b1405c8a339e9eada
    }

    public class AttributeManager
    {
        public static BitmapImage One = new BitmapImage(new Uri("ms-appx///Images/c1.jpeg"));
        public static BitmapImage Two = new BitmapImage(new Uri("ms-appx///Images/c2.jpeg"));
        public static BitmapImage Three = new BitmapImage(new Uri("ms-appx///Images/c3.jpg"));

        public static List<Attributes> GetAttributes()
        {
            var attributes = new List<Attributes>();

<<<<<<< HEAD

            attributes.Add(new Attributes { RoomId = "Rum 1", FrontImage = "ms-appx:///Images/c1.jpeg", BackImage = "ms-appx:///Images/c2.jpeg" , Projector = true, Wboard = true });
            attributes.Add(new Attributes { RoomId = "Rum 2", FrontImage = "ms-appx:///Images/c3.jpg", BackImage = "ms-appx:///Images/c2.jpeg", Projector = true, Wboard= true });
            attributes.Add(new Attributes { RoomId = "Rum 3", FrontImage = "ms-appx:///Images/c1.jpeg", BackImage = "ms-appx:///Images/c3.jpg" , Projector = true, Wboard = true });
            attributes.Add(new Attributes { RoomId = "Rum 4", FrontImage = "ms-appx:///Images/c1.jpeg", BackImage = "ms-appx:///Images/c1.jpeg" , Projector = true, Wboard = true });
            attributes.Add(new Attributes { RoomId = "Rum 5", FrontImage = "ms-appx:///Images/c3.jpg", BackImage = "ms-appx:///Images/c1.jpeg" , Projector = true, Wboard = true });
            attributes.Add(new Attributes { RoomId = "Rum 6", FrontImage = "ms-appx:///Images/c2.jpeg", BackImage = "ms-appx:///Images/c2.jpeg", Projector = true, Wboard = true });
            attributes.Add(new Attributes { RoomId = "Rum 7", FrontImage = "ms-appx:///Images/c3.jpg", BackImage = "ms-appx:///Images/c1.jpeg", Projector = true, Wboard = true });
            attributes.Add(new Attributes { RoomId = "Rum 8", FrontImage = "ms-appx:///Images/c2.jpeg", BackImage = "ms-appx:///Images/c1.jpeg", Projector = true, Wboard = true });


            return attributes;
         }
    }
             
    public class Images
    {
        public void GetAllImages()
        {
            BitmapImage One = new BitmapImage(new Uri("ms-appx///Images/c1.jpeg"));
            BitmapImage Two = new BitmapImage(new Uri("ms-appx///Images/c2.jpeg"));
            BitmapImage Three = new BitmapImage(new Uri("ms-appx///Images/c3.jpg"));

            Boolean[] tja = new Boolean[2] {true, false };

=======
            attributes.Add(new Attributes { RoomId = "Rum 1", FrontImage = "ms-appx:///Images/c1.jpeg", BackImage = "ms-appx:///Images/c2.jpeg" , Projector = true, Wboard = false, Seats = 8 });
            attributes.Add(new Attributes { RoomId = "Rum 2", FrontImage = "ms-appx:///Images/c3.jpg", BackImage = "ms-appx:///Images/c2.jpeg", Projector = false, Wboard = true, Seats = 10 });
            attributes.Add(new Attributes { RoomId = "Rum 3", FrontImage = "ms-appx:///Images/c1.jpeg", BackImage = "ms-appx:///Images/c3.jpg" , Projector = false, Wboard = false, Seats = 4 });
            attributes.Add(new Attributes { RoomId = "Rum 4", FrontImage = "ms-appx:///Images/c1.jpeg", BackImage = "ms-appx:///Images/c1.jpeg" , Projector = true, Wboard = true, Seats = 15 });
            attributes.Add(new Attributes { RoomId = "Rum 5", FrontImage = "ms-appx:///Images/c3.jpg", BackImage = "ms-appx:///Images/c1.jpeg" , Projector = true, Wboard = false, Seats = 7 });
            attributes.Add(new Attributes { RoomId = "Rum 6", FrontImage = "ms-appx:///Images/c2.jpeg", BackImage = "ms-appx:///Images/c2.jpeg" , Projector = false, Wboard = true, Seats = 22 });
            attributes.Add(new Attributes { RoomId = "Rum 7", FrontImage = "ms-appx:///Images/c3.jpg", BackImage = "ms-appx:///Images/c1.jpeg" , Projector = false, Wboard = false, Seats = 12 });
            attributes.Add(new Attributes { RoomId = "Rum 8", FrontImage = "ms-appx:///Images/c2.jpeg", BackImage = "ms-appx:///Images/c1.jpeg" , Projector = true, Wboard = true, Seats = 30 });
            return attributes;
>>>>>>> d979cef0d5e445b69855b97b1405c8a339e9eada
        }
    }
}
