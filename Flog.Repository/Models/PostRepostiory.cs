using Flog.Contracts.Repository.QueryParameters;
using Flog.Contracts.Repository;
using Flog.Entities;
using Flog.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace Flog.Repository.Models;

public class PostRepository : RepositoryBase<Post>, IPostRepository
{
    public PostRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {}
    
    public PostQueryParameters PostQueryParameters { get; set; }

    public void CreatePost(Post post) =>
        Create(post);

    public void UpdatePost(Post post) =>
        Update(post);

    public void DeletePost(Post post) => 
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

    public async Task<Post?> GetPostById(Guid postId, bool trackChanges) =>
        await GetByCondition(post => post.Id.Equals(postId), trackChanges)
            .SingleOrDefaultAsync();

    public async Task<IEnumerable<Post>> GetPostsByTag(Guid tagId, bool trackChanges) =>
        await GetByCondition(post => post.Tags.Any(tag => tag.TagId.Equals(tagId)), trackChanges)
            .ToListAsync();

    public async Task<IEnumerable<Post>> GetPostsByTags(IEnumerable<Guid> tagsId, bool trackChanges) =>
        await GetByCondition(post => post.Tags.Any(tag => tagsId.Contains(tag.TagId)), trackChanges)
            .ToListAsync();

    public async Task<IEnumerable<Post>> GetPagedPosts(int page, bool trackChanges)
    {
        int pageStart = (page * PostQueryParameters.PageSize) - 1;
        int pageEnd = PostQueryParameters.PageSize - 1;

        return await GetAll(trackChanges)
            .OrderByDescending(post => post.Created)
            .Skip(pageStart)
            .Take(pageEnd)
            .ToListAsync();
    }
}