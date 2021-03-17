using MapControlWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapControlWPF.IServices
{
    public interface ICustomerService
    {
        IEnumerable<Customer> Get();
    }
}
