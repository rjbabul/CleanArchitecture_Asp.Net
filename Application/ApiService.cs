using Application.Abstraction;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class ApiService : IApiService
    {
        private readonly ICustomerRepository _repository;

        public ApiService(ICustomerRepository respository)
        {
            _repository = respository;
        }

        public CustomerModels addCustomer(CustomerModels customer)
        {
            _repository.addCustomer(customer);
            return customer;
        }

        public List<CustomerModels> getallCustomer()
        {
            var customerList = _repository.getallCustomer();

            return customerList;
        }
    }
}
