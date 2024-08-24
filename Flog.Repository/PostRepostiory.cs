using Flog.Entities;
using Flog.Repository.Context;

using Microsoft.EntityFrameworkCore;

namespace Flog.Repository.Models;

public class PostQueryParameters
{
    public int PageSize { get; set; }
}

public class PostRepository : RepositoryBase<Post>
{
    public PostRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {}
    
    public PostQueryParameters PostQueryParameters { get; set; }

    public void CreatPost(Post post) =>
        Create(post);

    public void UpdatePost(Post post) =>
        UpdatePost(post);

    public void DeltePost(Post post) => 
        Delete(post);

    public async Task<IEnumerable<Post>> GetAllPosts(bool trackChanges) =>
        await GetAll(trackChanges)
            .ToListAsync();

    public async Task<IEnumerable<Post>> GetSelfPosts(Guid userTargetId, bool trackChanges) =>
        await GetByCondition(post => post.Author.Equals(userTargetId), trackChanges)
            .ToListAsync();

    public async Task<IEnumerable<Post>> GetUserPosts(Guid userTargetId, bool trackChanges) =>
        await GetByCondition(post => post.Author.Equals(userTargetId) && !post.Private, trackChanges)
            .ToListAsync();

    public async Task<IEnumerable<Post>> GetLastPosts(bool trackChanges) =>
        await GetAll(trackChanges)
            .OrderByDescending(post => post.Created)
            .Take(PostQueryParameters.PageSize)
            .ToListAsync();

    public async Task<IEnumerable<Post>> GetPagedPost(int page, bool trackChanges) 
    {
        int pageStart = (page * PostQueryParameters.PageSize) - 1;
        int pageEnd = PostQueryParameters.PageSize - 1;

        return await GetAll(trackChanges)
            .OrderByDescending(post => post.Created)
            .Skip(pageStart)
            .Take(pageEnd)
            .ToListAsync();
    }

    public async Task<Post?> GetPostById(Guid postId, bool trackChanges) =>
        await GetByCondition(post => post.Id.Equals(postId), trackChanges)
            .SingleOrDefaultAsync();
}