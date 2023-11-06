using System.Threading.Tasks;
namespace Contracts;
public interface IRepositoryManager
{
	IUserRepository Users {get; set;}
	IFlogRepository Flogs {get; set;}

	Task DumpAsync();
}