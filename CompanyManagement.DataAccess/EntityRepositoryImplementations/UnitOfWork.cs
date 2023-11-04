using CompanyManagement.DataAccess.Data;
using CompanyManagement.Domain.EntityRepositoryInterfaces;
namespace CompanyManagement.DataAccess.EntityRepositoryImplementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext appDbContext;
        public UnitOfWork(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
            Employee = new EmployeeRepository(appDbContext);
            Customer = new CustomerRepository(appDbContext);
            Order = new OrderRepository(appDbContext);
        }
        public IEmployeeRepository Employee { get; private set; }

        public ICustomerRepository Customer { get; private set; }

        public IOrderRepository Order { get; private set; }

        public void Dispose()
        {
            appDbContext.Dispose();
        }

        public int SaveChanges()
        {
            return appDbContext.SaveChanges();
        }
    }
}
