
namespace Flog.Contracts.Repository;

public interface IRepositoryManager
{
    public IUserRepository UserRepository { get; }

    public IPostRepository PostRepository { get; }

    public ITagRepository TagRepository { get; }
}
