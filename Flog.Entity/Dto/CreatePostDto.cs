namespace Flog.Entity.Dto;

public class CreatePostDto
{    
    public string Title { get; set; }
    
    public string Content { get; set; }

    public DateTime Created { get; set; }

    public Guid Author { get; set; }

    public Guid PodId { get; set; }

    public bool Private { get; set; }

    public IEnumerable<Guid> Tags { get; set; }

    public IEnumerable<Guid> BlockedToView { get; set; }

}
