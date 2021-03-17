using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapControlWPF.Models
{
    public abstract class Base
    {

    }

    public class Customer : Base
    {
        public string Name { get; set; }
        public Location Location { get; set; }

      
    }

    //public class Location : Base
    //{
    //    public double Latitude { get; set; }
    //    public double Longitude { get; set; }
    //}
}
