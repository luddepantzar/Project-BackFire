﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BackFire.Models
{
    public class Attribute
    {
        public int RoomId { get; set; }
        //public string Projector { get; set; }
        //public string Wboard { get; set; }
        public string FrontImage { get; set; }
        public string BackImage { get; set; }

    }

    public class AttributeManager
    {
        public static List<Attribute> GetAttributes()
        {
            var attributes = new List<Attribute>();

            attributes.Add(new Attribute { RoomId = 1, FrontImage = "ms-appx:///Images/c1.jpeg", BackImage = "ms-appx:///Images/c2.jpeg" });
            attributes.Add(new Attribute { RoomId = 2, FrontImage = "Assets/c3.jpg", BackImage = "Assets/c2.jpeg" });
            attributes.Add(new Attribute { RoomId = 3, FrontImage = "Assets/c1.jpeg", BackImage = "Assets/c3.jpg" });
            attributes.Add(new Attribute { RoomId = 4, FrontImage = "Assets/c1.jpeg", BackImage = "Assets/c1.jpeg" });
            attributes.Add(new Attribute { RoomId = 5, FrontImage = "Assets/c2.jpeg", BackImage = "Assets/c1.jpeg" });
            attributes.Add(new Attribute { RoomId = 6, FrontImage = "Assets/c3.jpg", BackImage = "Assets/c2.jpeg" });
            attributes.Add(new Attribute { RoomId = 7, FrontImage = "Assets/c2.jpeg", BackImage = "Assets/c1.jpeg" });
            attributes.Add(new Attribute { RoomId = 8, FrontImage = "Assets/c3.jpg", BackImage = "Assets/c1.jpeg" });


            return attributes;

        }

    }

}
