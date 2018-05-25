
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

public class room_Rootobject
{
    public List<Class2> Property1 { get; set; }

}

public class Class2
{
    public List<Roomattribute> roomAttributes { get; set; }
    public string name { get; set; }
    public string id { get; set; }
    public int seats { get; set; }
    public int? availableFrom { get; set; }
    public int? availableTo { get; set; }
}

public class Roomattribute
{
    public int id { get; set; }
    public string name { get; set; }
    public int icon { get; set; }
}
