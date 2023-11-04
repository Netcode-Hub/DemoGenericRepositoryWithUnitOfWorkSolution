using CompanyManagement.DataAccess.Data;
using CompanyManagement.Domain.GenericRepositoryInterface;
namespace CompanyManagement.DataAccess.GenericRepositoryImplementation
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AppDbContext appDbContext;
        public GenericRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public void Add(T entity) => appDbContext.Set<T>().Add(entity);

        public void Delete(T entity) => appDbContext.Set<T>().Remove(entity);

        public List<T> Find(System.Linq.Expressions.Expression<Func<T, bool>> predicate) => appDbContext.Set<T>().Where(predicate).ToList();

        public List<T> GetAll() => appDbContext.Set<T>().ToList();

        public T GetById(int id) => appDbContext.Set<T>().Find(id);

        public void Update(T entity) => appDbContext.Update(entity);
    }
}
