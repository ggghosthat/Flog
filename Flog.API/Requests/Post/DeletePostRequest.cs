using Flog.Entity.Dto;
using MediatR;

namespace Flog.API.Requests.Post;

public record DeletePostRequest(Guid RequestId, Guid DeletePostId) : INotification;
