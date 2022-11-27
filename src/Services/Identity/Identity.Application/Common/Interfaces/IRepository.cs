
namespace sattec.Identity.Application.Common.Repository
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity obj);
        void AddMany(List<TEntity> entities);
        Task<TEntity> GetById(Guid id);
        Task<IEnumerable<TEntity>> GetAll();
        System.Linq.IQueryable<TEntity> All();
        System.Linq.IQueryable<TEntity> All(int page, int pageSize);
        void Update(TEntity obj);
        void Remove(Guid id);
        System.Linq.IQueryable<TEntity> Query();

    }
}
