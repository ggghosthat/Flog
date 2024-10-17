using MediatR;

namespace Flog.API.Requests.Post;

public record GetTargetedUserPostsRequest(Guid RequestId, Guid UserId) : INotification;
