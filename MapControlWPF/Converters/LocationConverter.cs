using MapControlWPF.Models;
using Microsoft.Maps.MapControl.WPF;
using System;
using System.Globalization;
using System.Windows.Data;

namespace MapControlWPF.Converters
{
    public class LocationConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Coordinate coordinate = (Coordinate)value;

            Location location = new Location(coordinate.Latitude, coordinate.Longitude);

            return location;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
