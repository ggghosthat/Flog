using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flog.Entities;

public class Comment
{
    [Column("comment id")]
    public Guid Id { get; set; }
    
    [Display(Name = "post id")]
	[Required(ErrorMessage = "PostId is required.")]
    public Guid PostId { get; set; }

    [Display(Name = "source user")]
	[Required(ErrorMessage = "Source user is required.")]
    public Guid UserSourceId { get; set; } 

    [Display(Name = "content")]
	[Required(ErrorMessage = "Content is required.")]
	public string Content { get; set; }

    public Comment ParentComment { get; set; }

    public IEnumerable<Comment> ChildComments { get; set; }
}