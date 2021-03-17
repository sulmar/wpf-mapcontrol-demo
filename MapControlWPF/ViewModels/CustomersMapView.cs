using MapControlWPF.FakeServices;
using MapControlWPF.IServices;
using MapControlWPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapControlWPF.ViewModels
{
    public class CustomersMapView
    {
        public ObservableCollection<Customer> Customers { get; set; }

        private readonly ICustomerService customerService;

        public CustomersMapView()
            :this(new FakeCustomerService())
        {

        }
        public CustomersMapView(ICustomerService customerService)
        {
            this.customerService = customerService;

            Customers = new ObservableCollection<Customer>(customerService.Get());
        }
    }
}
