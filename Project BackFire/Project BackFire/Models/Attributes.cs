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
        public bool Tv { get; set; }
        public bool Wifi { get; set; }
        public string CompanyNote { get; set; }
=======
<<<<<<< HEAD
        public string Note { get; set; }
=======
<<<<<<< HEAD
        public string CompanyNote { get; set; }
=======
>>>>>>> 5d862a1313d283e597d864f9a6eff82345ff1d49

>>>>>>> e771a96420580d9e3ea6995c12fb55a81633f571
>>>>>>> 94d6947c351e63df93954cfe2dfe1ce545f32682
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
            attributes.Add(new Attributes { RoomId = "Rum 1", FrontImage = "ms-appx:///Images/c1.jpeg", BackImage = "ms-appx:///Images/c2.jpeg", Projector = true, Wboard = false, Tv = false, Wifi = true, Seats = 8 });
            attributes.Add(new Attributes { RoomId = "Rum 2", FrontImage = "ms-appx:///Images/c3.jpg", BackImage = "ms-appx:///Images/c2.jpeg", Projector = false, Wboard = true, Tv = true, Wifi = true, Seats = 10});
            attributes.Add(new Attributes { RoomId = "Rum 3", FrontImage = "ms-appx:///Images/c1.jpeg", BackImage = "ms-appx:///Images/c3.jpg", Projector = false, Wboard = false, Tv = true, Wifi = false, Seats = 4 });
            attributes.Add(new Attributes { RoomId = "Rum 4", FrontImage = "ms-appx:///Images/c1.jpeg", BackImage = "ms-appx:///Images/c1.jpeg", Projector = true, Wboard = true, Tv = false, Wifi = true, Seats = 15 });
            attributes.Add(new Attributes { RoomId = "Rum 5", FrontImage = "ms-appx:///Images/c3.jpg", BackImage = "ms-appx:///Images/c1.jpeg", Projector = true, Wboard = false, Tv = false, Wifi = true, Seats = 7 });
            attributes.Add(new Attributes { RoomId = "Rum 6", FrontImage = "ms-appx:///Images/c2.jpeg", BackImage = "ms-appx:///Images/c2.jpeg", Projector = false, Wboard = true, Tv = true, Wifi = false, Seats = 22 });
            attributes.Add(new Attributes { RoomId = "Rum 7", FrontImage = "ms-appx:///Images/c3.jpg", BackImage = "ms-appx:///Images/c1.jpeg", Projector = false, Wboard = false, Tv = true, Wifi = true, Seats = 12 });
            attributes.Add(new Attributes { RoomId = "Rum 8", FrontImage = "ms-appx:///Images/c2.jpeg", BackImage = "ms-appx:///Images/c1.jpeg", Projector = true, Wboard = true, Tv = false, Wifi = false, Seats = 30 });
=======
<<<<<<< HEAD
            attributes.Add(new Attributes { RoomId = "Rum 1", FrontImage = "ms-appx:///Images/c1.jpeg", BackImage = "ms-appx:///Images/c2.jpeg", Projector = true, Wboard = false, Seats = 8 });
            attributes.Add(new Attributes { RoomId = "Rum 2", FrontImage = "ms-appx:///Images/c3.jpg", BackImage = "ms-appx:///Images/c2.jpeg", Projector = false, Wboard = true, Seats = 10 });
            attributes.Add(new Attributes { RoomId = "Rum 3", FrontImage = "ms-appx:///Images/c1.jpeg", BackImage = "ms-appx:///Images/c3.jpg", Projector = false, Wboard = false, Seats = 4 });
            attributes.Add(new Attributes { RoomId = "Rum 4", FrontImage = "ms-appx:///Images/c1.jpeg", BackImage = "ms-appx:///Images/c1.jpeg", Projector = true, Wboard = true, Seats = 15 });
            attributes.Add(new Attributes { RoomId = "Rum 5", FrontImage = "ms-appx:///Images/c3.jpg", BackImage = "ms-appx:///Images/c1.jpeg", Projector = true, Wboard = false, Seats = 7 });
            attributes.Add(new Attributes { RoomId = "Rum 6", FrontImage = "ms-appx:///Images/c2.jpeg", BackImage = "ms-appx:///Images/c2.jpeg", Projector = false, Wboard = true, Seats = 22 });
            attributes.Add(new Attributes { RoomId = "Rum 7", FrontImage = "ms-appx:///Images/c3.jpg", BackImage = "ms-appx:///Images/c1.jpeg", Projector = false, Wboard = false, Seats = 12 });
            attributes.Add(new Attributes { RoomId = "Rum 8", FrontImage = "ms-appx:///Images/c2.jpeg", BackImage = "ms-appx:///Images/c1.jpeg", Projector = true, Wboard = true, Seats = 30 });
=======

            attributes.Add(new Attributes { RoomId = "Rum 1", FrontImage = "ms-appx:///Images/c1.jpeg", BackImage = "ms-appx:///Images/c2.jpeg" , Projector = true, Wboard = true, Note = "Lorem ipsum dolor sit amet, co"});
            attributes.Add(new Attributes { RoomId = "Rum 2", FrontImage = "ms-appx:///Images/c3.jpg", BackImage = "ms-appx:///Images/c2.jpeg", Projector = true, Wboard= true });
            attributes.Add(new Attributes { RoomId = "Rum 3", FrontImage = "ms-appx:///Images/c1.jpeg", BackImage = "ms-appx:///Images/c3.jpg" , Projector = true, Wboard = true });
            attributes.Add(new Attributes { RoomId = "Rum 4", FrontImage = "ms-appx:///Images/c1.jpeg", BackImage = "ms-appx:///Images/c1.jpeg" , Projector = true, Wboard = true });
            attributes.Add(new Attributes { RoomId = "Rum 5", FrontImage = "ms-appx:///Images/c3.jpg", BackImage = "ms-appx:///Images/c1.jpeg" , Projector = true, Wboard = true });
            attributes.Add(new Attributes { RoomId = "Rum 6", FrontImage = "ms-appx:///Images/c2.jpeg", BackImage = "ms-appx:///Images/c2.jpeg", Projector = true, Wboard = true });
            attributes.Add(new Attributes { RoomId = "Rum 7", FrontImage = "ms-appx:///Images/c3.jpg", BackImage = "ms-appx:///Images/c1.jpeg", Projector = true, Wboard = true });
            attributes.Add(new Attributes { RoomId = "Rum 8", FrontImage = "ms-appx:///Images/c2.jpeg", BackImage = "ms-appx:///Images/c1.jpeg", Projector = true, Wboard = true });
>>>>>>> e771a96420580d9e3ea6995c12fb55a81633f571


>>>>>>> 94d6947c351e63df93954cfe2dfe1ce545f32682
            return attributes;
         }
    }
}
