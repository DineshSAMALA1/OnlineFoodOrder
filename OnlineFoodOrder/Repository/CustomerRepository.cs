using OnlineFoodOrder.Data;
using OnlineFoodOrder.Models.Domain;

namespace OnlineFoodOrder.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly MVCDemoDbContext _mVCDemoDbContext;

        public CustomerRepository(MVCDemoDbContext context)
        {
            _mVCDemoDbContext = context;

        }

        public IEnumerable<Customer> GetCustomer()
        {
            return _mVCDemoDbContext.Customers;
        }

        Customer ICustomerRepository.GetCustomer()
        {
            throw new NotImplementedException();
        }
    }
}
