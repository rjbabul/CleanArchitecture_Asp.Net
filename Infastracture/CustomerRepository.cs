using Application.Abstraction;
using Domain;
using Infrastracture.Database;

namespace Infrastracture.Repository
{
    public class CustomerRepository : ICustomerRepository
    {

        ApplicationDbContext _db;
        public CustomerRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public List<CustomerModels> getallCustomer()
        {
            var ListOfCustomer = _db.Customers.ToList();
            
            return ListOfCustomer;
        }
        public CustomerModels addCustomer(CustomerModels customer)
        {
            _db.Customers.Add(customer);
            _db.SaveChanges();

            return customer;
        }
    }
}
