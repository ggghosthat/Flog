using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flog.Entities;

public class Post
{
	[Column("post id")]
	public Guid Id { get; set; }

	[Display(Name = "title")]
	[Required(ErrorMessage = "Title is required.")]
	public string Title { get; set; }	

	[Display(Name = "post content")]
	[Required(ErrorMessage = "Content is required.")]
	public string Content { get; set; }

	[Display(Name = "post created date")]
	[Required(ErrorMessage = "Created date is required.")]
	public DateTime Created { get; set; }

	[Required(ErrorMessage = "Author is required.")]
	public Guid Author { get; set; }

	[Required(ErrorMessage = "Published place is required.")]
	public Guid PodId { get; set; }

	public bool Private { get; set; } = false;

	public IEnumerable<Guid> AllowedViewers { get; set; }

	public IEnumerable<Guid> Tags { get; set; }

	public long Viewed { get; set; }

	public long Rate { get; set; }
}