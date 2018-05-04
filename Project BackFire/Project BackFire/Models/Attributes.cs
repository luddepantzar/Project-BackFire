using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_BackFire.ViewModels;
using Project_BackFire.Views;
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
        public Boolean Projector { get; set; }
        public Boolean Whiteboard { get; set; }
    }

    public class AttributeManager
    {
        public static List<Attributes> GetAttributes()
        {
            var attributes = new List<Attributes>();

<<<<<<< HEAD
            attributes.Add(new Attributes { RoomId = 1, FrontImage = "ms-appx:///Images/c1.jpeg", BackImage = "ms-appx:///Images/c2.jpeg", Seats = 8});
            attributes.Add(new Attributes { RoomId = 2, FrontImage = "Assets/c3.jpg", BackImage = "Assets/c2.jpeg", Seats = 10 });
            attributes.Add(new Attributes { RoomId = 3, FrontImage = "Assets/c1.jpeg", BackImage = "Assets/c3.jpg", Seats = 30 });
            attributes.Add(new Attributes { RoomId = 4, FrontImage = "Assets/c1.jpeg", BackImage = "Assets/c1.jpeg", Seats = 4 });
            attributes.Add(new Attributes { RoomId = 5, FrontImage = "Assets/c2.jpeg", BackImage = "Assets/c1.jpeg", Seats = 6 });
            attributes.Add(new Attributes { RoomId = 6, FrontImage = "Assets/c3.jpg", BackImage = "Assets/c2.jpeg", Seats = 12 });
            attributes.Add(new Attributes { RoomId = 7, FrontImage = "Assets/c2.jpeg", BackImage = "Assets/c1.jpeg", Seats = 11 });
            attributes.Add(new Attributes { RoomId = 8, FrontImage = "Assets/c3.jpg", BackImage = "Assets/c1.jpeg", Seats = 25 });

            return attributes;          
=======
            attributes.Add(new Attributes { RoomId = "Rum 1", FrontImage = "ms-appx:///Images/c1.jpeg", BackImage = "ms-appx:///Images/c2.jpeg" , Projector = true, Wboard = true });
            attributes.Add(new Attributes { RoomId = "Rum 2", FrontImage = "ms-appx:///Images/c3.jpg", BackImage = "ms-appx:///Images/c2.jpeg", Projector = true, Wboard= true });
            attributes.Add(new Attributes { RoomId = "Rum 3", FrontImage = "ms-appx:///Images/c1.jpeg", BackImage = "ms-appx:///Images/c3.jpg" , Projector = true, Wboard = true });
            attributes.Add(new Attributes { RoomId = "Rum 4", FrontImage = "ms-appx:///Images/c1.jpeg", BackImage = "ms-appx:///Images/c1.jpeg" , Projector = true, Wboard = true });
            attributes.Add(new Attributes { RoomId = "Rum 5", FrontImage = "ms-appx:///Images/c3.jpg", BackImage = "ms-appx:///Images/c1.jpeg" , Projector = true, Wboard = true });
            attributes.Add(new Attributes { RoomId = "Rum 6", FrontImage = "ms-appx:///Images/c2.jpeg", BackImage = "ms-appx:///Images/c2.jpeg" , Projector = true, Wboard = true });
            attributes.Add(new Attributes { RoomId = "Rum 7", FrontImage = "ms-appx:///Images/c3.jpg", BackImage = "ms-appx:///Images/c1.jpeg" , Projector = true, Wboard = true });
            attributes.Add(new Attributes { RoomId = "Rum 8", FrontImage = "ms-appx:///Images/c2.jpeg", BackImage = "ms-appx:///Images/c1.jpeg" , Projector = true, Wboard = true });
            return attributes;
>>>>>>> 171b312c16211002225a75f3e7b492b778c6febf
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

        }
    }
}
