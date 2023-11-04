using CompanyManagement.DataAccess.Data;
using CompanyManagement.DataAccess.GenericRepositoryImplementation;
using CompanyManagement.Domain.DatabaseEntities;
using CompanyManagement.Domain.EntityRepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
namespace CompanyManagement.DataAccess.EntityRepositoryImplementations
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        private readonly AppDbContext appDbContext;
        public CustomerRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public List<Customer> GetCustomersWithOrders()
        {
            var results = appDbContext.Customers.Include(_ => _.Orders).ToList();
            return results;
        }
    }
}
