namespace Entities.Models;
public class Flog
{
	[Column("UserId")]
	public Guid Id {get; set;}

	[Display(Name = "title")]
	[Required(ErrorMessage = "Title is required.")]
	public string Title {get; set;}	

	[Display(Name = "post content")]
	[Required(ErrorMessage = "Content is required.")]
	public string Content {get; set;}

	[Required(ErrorMessage = "Author is required.")]
	public Guid Author {get; set;}

	[Required(ErrorMessage = "Published place is required.")]
	public Guid PodId {get; set;}


	public bool Private {get; set;} = false;

	public IEnumerable<Guid> AllowedViewers {get; set;}

	public IEnumerable<Guid> Tags {get; set;}

	public int Viewed {get; set;}

	public int Rate {get; set;}
	
}