using Flog.API.Routes;
using Flog.Entities;
using Flog.Entity.Dto;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Flog.API.Controllers.v1
{
    [Route(ApiRoutes.Post.Controller)]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PostController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(ApiRoutes.Post.GetLatestFeed, Name = "GetLatestFeed")]
        public async Task<ActionResult> GetLatestFeed()
        {
            return null;
        }

        [HttpGet(ApiRoutes.Post.GetPagedFeed, Name = "GetPagedFeed")]
        public async Task<IEnumerable<Post>> GetPagedFeed(int page)
        {
            return null;
        }

        [HttpGet(ApiRoutes.Post.GetSelfPosts)]
        public async Task<ActionResult> GetSelfPosts([FromBody] User user)
        {
            return null;
        }

        [HttpGet(ApiRoutes.Post.GetTargetedUserPosts)]
        public async Task<ActionResult> GetTargetedUserPost([FromBody] User user)
        {
            return null;
        }

        [HttpGet(ApiRoutes.Post.GetPostById, Name = "GetTargetUser")]
        public async Task<ActionResult> GetPostById([FromHeader] Guid postId)
        { 
            return null;
        }

        [HttpGet(ApiRoutes.Post.GetPostsByTag, Name = "GetTargetUser")]
        public async Task<ActionResult> GetPostsByTags([FromBody] IEnumerable<Tag> tags)
        {
            return null;
        }

        [HttpPost]
        public async Task<ActionResult> CreatePost([FromBody] CreatePostDto postDto)
        {
            return null;
        }

        [HttpGet]
        public async Task<ActionResult> EditPost([FromBody] EditPostDto post)
        {
            return null;
        }

        [HttpGet]
        public async Task<ActionResult> DeletePost([FromHeader] Guid postId)
        {
            return null;
        }
    }
}
