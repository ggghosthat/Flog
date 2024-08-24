using Flog.Contracts.Repository;
using Flog.Repository.Context;

namespace Flog.Repository.Models;

public sealed class Repositorymanager : IRepositoryManager
{
    private readonly RepositoryContext _repositoryContext;

    private IUserRepository _userRepository = null;
    
    private IPostRepository _postRepository;
    
    private ITagRepository _tagRepository;

    public Repositorymanager(RepositoryContext repositoryContext) =>
        _repositoryContext = repositoryContext;

    public IUserRepository UserRepository
    {
        get
        {
            if (_userRepository == null)
                _userRepository = new UserRepository(_repositoryContext);
            return _userRepository;
        }
    }

    public IPostRepository PostRepository
    {
        get
        {
            if (_postRepository == null)
                _postRepository = new PostRepository(_repositoryContext);

            return _postRepository;
        }
    }

    public ITagRepository TagRepository
    {
        get
        {
            if ( _tagRepository == null)
                _tagRepository = new TagRepository(_repositoryContext);
            
            return _tagRepository;
        }
    }
}