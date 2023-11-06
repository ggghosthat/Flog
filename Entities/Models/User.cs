using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;
public class User
{
	[Column("UserId")]
	public Guid Id {get; set;}

	[Display(Name = "nickname")]
	[Required(ErrorMessage = "User name is required.")]
	public string Nickname {get; set;}

	public string Bio {get; set;}

	[Display(Name = "birthday")]
	[Required(ErrorMessage = "Birthday is required.")]
	public DateTime Birthday {get; set;}	

	[Display(Name = "e-mail")]
	[Required(ErrorMessage = "E-mail address is required.")]
	[EmailAddress(ErrorMessage="Your e-mail address is invalid.")]
	public string Email {get; set;}

	[Required(ErrorMessage = "Phone number is required.")]
	[Display(Name = "phone")]
	[DataType(DataType.PhoneNumber)]
	[RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Phone number is invalid.")]
	public string Phone {get; set;}

	[Display(name="posts")]
	public IEnumerable<Guid> Posts {get; set;}

	public IEnumerable<Guid> Friends {get; set;}
}
