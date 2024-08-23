namespace Flog.Entities;

public class Tag
{
	public Guid TagId {get; set;}
	public string Title {get; set;}
	public IEnumerable<Guid> Flogs {get; set;}
}