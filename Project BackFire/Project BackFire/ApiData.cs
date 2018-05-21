using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace Project_BackFire
{
    class ApiData
    {
    }
}

public class Rootobject
{
    public List<Class1> Property1 { get; set; }

    public string name { get; set; }
    public string id { get; set; }
    public DateTime createdDate { get; set; }
    public string code { get; set; }
    public string mainColor { get; set; }
    public int timeInterval { get; set; }
    public int maxSeats { get; set; }
}

public class Class1
{

}
