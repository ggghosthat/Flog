using Entities.Models;
using System.Threading.Tasks;

namespace Contracts;
public interface IUserRepository
{
	Task<IEnumerable<User>> GetUsersAsync();
	Task<User> GetUserAsync(Guid userId);
	void CreateUser(User user);
	void EditUser(User user);
	void DeleteUser(Guid userId);
}