using Entities.Models;
using System.Threading.Tasks;

namespace Contracts;
public interface IFlogRepository
{
	Task<IEnumerable<User>> GetFlogsAsync(Guid userId);
	void CreateFlog(Flog flog);
	void EditUser(Flog flog);
	void DeleteUser(Guid flogId);
}