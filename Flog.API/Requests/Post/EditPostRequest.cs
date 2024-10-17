using Flog.Entity.Dto;
using MediatR;

namespace Flog.API.Requests.Post;

public record EditPostRequest(Guid RequestId, EditPostDto EditPostDto) : INotification;
