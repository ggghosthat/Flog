
using Flog.Entities;
using Flog.Repository.Context;

namespace Flog.Repository.Models;

public class UserRepository : RepositoryBase<User>
{
    public UserRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {}

    
}
