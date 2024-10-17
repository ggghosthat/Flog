using MediatR;

namespace Flog.API.Requests.Post;

public record GetPagedFeedRequest(Guid RequestId) : INotification;
