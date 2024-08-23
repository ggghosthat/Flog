
using Flog.Entities;
using Flog.Repository.Context;

using Microsoft.EntityFrameworkCore;

namespace Flog.Repository.Models;

public class UserRepository : RepositoryBase<User>
{
    public UserRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {}

    public void CreateUser(User user)
    {
        Create(user);
    }

    public void UpdateUser(User user)
    {
        Update(user);
    }

    public void DeleteUser(User user)
    {
        Delete(user);
    }

    public async Task<IEnumerable<User>> GetAllUsers(bool trackChaneges)
    {
        return await GetAll(trackChaneges).ToListAsync();
    }

    public async Task<User?> GetUserById(Guid userId, bool trackChanges)
    {
        return await GetByCondition(user => user.Id.Equals(userId), trackChanges).SingleOrDefaultAsync();
    }

    public async Task<IEnumerable<User>> GetUsersById(IEnumerable<Guid> usersId, bool trackChanges)
    {
        return await GetByCondition(user => usersId.Contains(user.Id), trackChanges).ToListAsync();
    }

    
}
