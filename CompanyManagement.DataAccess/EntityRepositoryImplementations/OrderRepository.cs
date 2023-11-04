using CompanyManagement.DataAccess.Data;
using CompanyManagement.DataAccess.GenericRepositoryImplementation;
using CompanyManagement.Domain.DatabaseEntities;
using CompanyManagement.Domain.EntityRepositoryInterfaces;
namespace CompanyManagement.DataAccess.EntityRepositoryImplementations
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
