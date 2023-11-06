namespace Entities.Models;
public class FlogTag
{
	public Guid TagId {get; set;}
	public string Content {get; set;}
	public IEnumerable<Guid> Flogs {get; set;}
}