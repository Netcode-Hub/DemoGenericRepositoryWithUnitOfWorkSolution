namespace CompanyManagement.Domain.EntityRepositoryInterfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IEmployeeRepository Employee { get; }
        ICustomerRepository Customer { get; }
        IOrderRepository Order { get; }
        int SaveChanges();
    }
}
