using CompanyManagement.Domain.DatabaseEntities;
using CompanyManagement.Domain.GenericRepositoryInterface;
namespace CompanyManagement.Domain.EntityRepositoryInterfaces
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
    }
}
