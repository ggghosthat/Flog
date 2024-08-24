using Flog.Contracts.Repository.QueryParameters;
using Flog.Entities;

namespace Flog.Contracts.Repository;

public interface ITagRepository
{
    public TagQueryParameters TagQueryParameters { get; set; }

    public void CreateTag(Tag tag);

    public void UpdateTag(Tag tag);

    public void DeleteTag(Tag tag);
    
    public Task<IEnumerable<Tag>> GetAllTags(bool trackChanges);

    public Task<Tag?> GetTagById(Guid tagId, bool trackChanges);

    public Task<IEnumerable<Tag>> GetTagsByTitle(string title, bool trackChanegs);

    public Task<IEnumerable<Tag>> GetPagedTags(int page, bool trackChanges);
}
