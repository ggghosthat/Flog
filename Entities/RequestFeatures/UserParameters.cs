namespace Entities.RequestFeatures;
public class UserParameters : RequestParameters
{
	public UserParameters()
	{
		OrderBy = "nickname";
	}

	public string SearchTerm {get; set;}

	public DateTime Created {get; set;}
}