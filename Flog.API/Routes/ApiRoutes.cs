namespace Flog.API.Routes;

public static class ApiRoutes
{
    public static class Post
    {
        public const string Controller = "/api/v1/post";

        public const string CreatePost = Controller;

        public const string DeletePost = Controller + "/delete/{id}";

        public const string EditPost = Controller + "/edit";

        public const string GetPostById = Controller + "{id}";

        public const string GetLatestFeed = Controller;

        public const string GetPagedFeed = Controller;

        public const string GetSelfPosts = Controller + "/self";

        public const string GetTargetedUserPosts = Controller;

        public const string GetPostsByTag = Controller;
    }
}
