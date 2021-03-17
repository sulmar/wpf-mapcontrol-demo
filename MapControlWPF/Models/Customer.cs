namespace MapControlWPF.Models
{
    public abstract class Base
    {

    }

    public class Customer : Base
    {
        public string Name { get; set; }
        public Coordinate Location { get; set; }

      
    }

    public class Coordinate : Base
    {
        public Coordinate()
        {

        }
        public Coordinate(double latitude, double longitude)
            : this()
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
