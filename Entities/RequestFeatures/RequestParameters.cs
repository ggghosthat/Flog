namespace Entities.RequestFeatures;
public abstract class RequestParameters
{
	private int maxPageSize = 15;

	private int pageSize = 10;

	public int CurrentPage {get; set;} = 1;


	public int PageSize
	{
		get => pageSize;
		set => pageSize = (value > maxPageSize)? maxPageSize : value;
	}

	public string OrderBy {get; set;}
}