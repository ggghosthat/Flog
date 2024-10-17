using MediatR;

namespace Flog.API.Requests.Post;

public record GetLatestFeedRequest(Guid RequestId, Guid SelfUserId) : INotification;

