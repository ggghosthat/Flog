using MediatR;

namespace Flog.API.Requests.Post;

public record GetPostByIdRequest(Guid RequestId, Guid PostId) : INotification;
