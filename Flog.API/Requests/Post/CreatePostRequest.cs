using Flog.Entity.Dto;
using MediatR;

namespace Flog.API.Requests.Post;

public record CreatePostRequest(Guid RequestId, CreatePostDto CreatePostDto) : INotification;
