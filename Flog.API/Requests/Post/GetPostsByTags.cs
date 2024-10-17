using MediatR;

namespace Flog.API.Requests.Post;

public record GetPostsByTags(Guid RequestId, IEnumerable<Guid> TagsId) : INotification;
