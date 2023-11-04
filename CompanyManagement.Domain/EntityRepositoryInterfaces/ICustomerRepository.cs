using CompanyManagement.Domain.DatabaseEntities;
using CompanyManagement.Domain.GenericRepositoryInterface;
namespace CompanyManagement.Domain.EntityRepositoryInterfaces
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        List<Customer> GetCustomersWithOrders();
    }
}
