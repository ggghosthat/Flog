using Flog.Contracts.Repository.QueryParameters;
using Flog.Entities;

namespace Flog.Contracts.Repository;

public interface IUserRepository
{
    public UserQueryParameters UserQueryParameters { get; set; }
    
    public void CreateUser(User user);
    
    public void UpdateUser(User user);

    public void DeleteUser(User user);

    public Task<IEnumerable<User>> GetAllUsers(bool trackChanges);

    public Task<User?> GetUserById(Guid id, bool trackChanges);

    public Task<IEnumerable<User>> GetUsersById(IEnumerable<Guid> usersId, bool trackChanges);

    public Task<IEnumerable<User>> SearchUsers(string searchTerm, bool trackChanges);

    public Task<IEnumerable<User>> GetUsersByBirthday(DateTime dateTime, bool trackChanges);

    public Task<IEnumerable<User>> GetPagedUsers(int page, bool trackChanges);
}
