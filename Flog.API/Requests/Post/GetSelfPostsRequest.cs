using MediatR;

namespace Flog.API.Requests.Post;

public record GetSelfPostsRequest(Guid RequestId, Guid SelfUserId) : INotification;
