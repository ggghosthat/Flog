using Flog.Contracts.Repository;
using Flog.Contracts.Repository.QueryParameters;
using Flog.Entities;
using Flog.Repository.Context;

using Microsoft.EntityFrameworkCore;

namespace Flog.Repository.Models;

public class TagRepository : RepositoryBase<Tag>, ITagRepository
{
    public TagRepository(RepositoryContext context) : base(context)
    {}

    public TagQueryParameters TagQueryParameters { get; set; }

    public void CreateTag(Tag tag) =>
        Create(tag);

    public void UpdateTag(Tag tag) =>
        Update(tag);

    public void DeleteTag(Tag tag) => 
        Delete(tag);

    public async Task<IEnumerable<Tag>> GetAllTags(bool trackChanges) =>
        await GetAll(trackChanges)
            .ToListAsync();

    public async Task<Tag?> GetTagById(Guid tagId, bool trackChanges) =>
        await GetByCondition(tag => tag.TagId.Equals(tagId), trackChanges)
            .SingleOrDefaultAsync();

    public async Task<IEnumerable<Tag>> GetTagsByTitle(string title, bool trackChanges) =>
        await GetByCondition(tag => tag.Title.Contains(title), trackChanges)
            .ToListAsync();

    public async Task<IEnumerable<Tag>> GetPagedTags(int page, bool trackChanges)
    {
        int pageStart = (page * TagQueryParameters.PageSize) - 1;
        int pageEnd = TagQueryParameters.PageSize - 1;

        return await GetAll(trackChanges)
            .OrderByDescending(tag => tag.Rate)
            .Skip(pageStart)
            .Take(pageEnd)
            .ToListAsync();
    }
}