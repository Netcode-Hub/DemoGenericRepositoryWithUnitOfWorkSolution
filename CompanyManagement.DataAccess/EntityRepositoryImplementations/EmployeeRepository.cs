using CompanyManagement.DataAccess.Data;
using CompanyManagement.DataAccess.GenericRepositoryImplementation;
using CompanyManagement.Domain.DatabaseEntities;
using CompanyManagement.Domain.EntityRepositoryInterfaces;
namespace CompanyManagement.DataAccess.EntityRepositoryImplementations
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(AppDbContext appDbContext) : base(appDbContext) { }
    }
}
