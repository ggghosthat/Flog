using System.Linq.Expressions;

namespace Flog.Contracts.Repository;

public interface IRepository<T> where T : class
{
    public void Create(T entity);
    public void Update(T entity);
    public void Delete(T entity);
    public IQueryable<T> GetAll(bool trackChanges);
    public IQueryable<T> GetByCondition(Expression<Func<T,bool>> condition, bool trackChanges);
}