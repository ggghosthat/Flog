namespace Entities.RequestFeatures;
public class FlogParameters : RequestParameters
{
	public FlogParameters()
	{
		OrderBy = "nickname";
	}

	public string SearchTerm {get; set;}

	public DateTime Created {get; set;}

	public Guid Author {get; set;}

	public IEnumerable<Guid> Tag {get; set;}
}