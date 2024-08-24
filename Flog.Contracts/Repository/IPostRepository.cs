using Flog.Contracts.Repository.QueryParameters;
using Flog.Entities;

namespace Flog.Contracts.Repository;

public interface IPostRepository
{
    public PostQueryParameters PostQueryParameters { get; set; }

    public void CreatePost(Post post);
    
    public void UpdatePost(Post post);
    
    public void DeletePost(Post post);

    public Task<IEnumerable<Post>> GetAllPosts(bool trackChanegs);

    public Task<IEnumerable<Post>> GetSelfPosts(Guid userTargetId, bool trackChanegs);

    public Task<IEnumerable<Post>> GetUserPosts(Guid userTargetId, bool trackChanegs);

    public Task<IEnumerable<Post>> GetLastPosts(bool trackChanegs);

    public Task<IEnumerable<Post>> GetPagedPosts(int page, bool trackChanegs);

    public Task<Post?> GetPostById(Guid postId, bool trackChanges);

    public Task<IEnumerable<Post>> GetPostsByTag(Guid tagId, bool trackChanges);
    
    public Task<IEnumerable<Post>> GetPostsByTags(IEnumerable<Guid> tagsId, bool trackChanges);

}
