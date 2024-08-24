using Flog.Contracts.Repository;
using Flog.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Flog.Repository.Models;

public class RepositoryBase<T> : IRepository<T> where T : class
{
    private RepositoryContext _repostioryContext;

    public RepositoryBase(RepositoryContext repostioryContext)
    {
        _repostioryContext = repostioryContext;
    }

    public void Create(T entity)
    {
        _repostioryContext.Set<T>().Add(entity);
    }

    public void Update(T entity)
    {
        _repostioryContext.Set<T>().Update(entity);
    }

    public void Delete(T entity)
    {        
        _repostioryContext.Set<T>().Remove(entity);
    }

    public IQueryable<T> GetAll(bool trackChanges)
    {        
        return trackChanges
            ? _repostioryContext.Set<T>()
            : _repostioryContext.Set<T>().AsNoTracking();
    }

    public IQueryable<T> GetByCondition(Expression<Func<T,bool>> condition, bool trackChanges)
    {
        return trackChanges
            ? _repostioryContext.Set<T>().Where(condition)
            : _repostioryContext.Set<T>().Where(condition).AsNoTracking();
    }   
}