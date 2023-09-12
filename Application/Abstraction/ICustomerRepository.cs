using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstraction
{
    public interface ICustomerRepository
    {
        List<CustomerModels> getallCustomer();
        CustomerModels addCustomer(CustomerModels customer);
    }
}
