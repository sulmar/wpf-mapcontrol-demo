using Bogus;
using MapControlWPF.Fakers;
using MapControlWPF.IServices;
using MapControlWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapControlWPF.FakeServices
{
    public class FakeCustomerService : ICustomerService
    {
        private readonly IEnumerable<Customer> customers;

        public FakeCustomerService()
            : this(new CustomerFaker(new LocationFaker()))
        {

        }

        public FakeCustomerService(Faker<Customer> faker)
        {
            customers = faker.Generate(10);
        }

        public IEnumerable<Customer> Get()
        {
            return customers;
        }
    }
}
