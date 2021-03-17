using Bogus;
using MapControlWPF.Models;
using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapControlWPF.Fakers
{
    public class CustomerFaker : Faker<Customer>
    {
        public CustomerFaker(Faker<Coordinate> faker)
        {
            RuleFor(p => p.Name, f => f.Person.FullName);
            RuleFor(p => p.Location, f => faker.Generate());
        }
    }

    public class LocationFaker : Faker<Location>
    {
        public LocationFaker()
        {
            RuleFor(p => p.Latitude, f =>  f.Address.Latitude(50, 52));
            RuleFor(p => p.Longitude, f => f.Address.Longitude(20, 22));
        }
    }

    public class CoordinateFaker : Faker<Coordinate>
    {
        public CoordinateFaker()
        {
            RuleFor(p => p.Latitude, f => f.Address.Latitude(50, 52));
            RuleFor(p => p.Longitude, f => f.Address.Longitude(20, 22));
        }
    }
}
