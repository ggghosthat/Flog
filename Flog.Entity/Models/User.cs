using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Flog.Entities;
public class User : IdentityUser
{
	[Column("UserId")]
	public Guid Id { get; set; }

	[Display(Name = "nickname")]
	[Required(ErrorMessage = "User name is required.")]
	public string Nickname { get; set; }

	[Display(Name = "BIO")]
	public string Bio { get; set; }

	[Display(Name = "Status")]
	public string Status { get; set; }

	[Display(Name = "user created date")]
	[Required(ErrorMessage = "Created date is required.")]
	public DateTime Created { get; set; }

	[Display(Name = "birthday")]
	[Required(ErrorMessage = "Birthday is required.")]
	public DateTime Birthday { get; set; }	

	[Display(Name = "e-mail")]
	[Required(ErrorMessage = "E-mail address is required.")]
	[EmailAddress(ErrorMessage="Your e-mail address is invalid.")]
	public string Email { get; set; }

	[Required(ErrorMessage = "Phone number is required.")]
	[Display(Name = "phone")]
	[DataType(DataType.PhoneNumber)]
	[RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Phone number is invalid.")]
	public string Phone { get; set; }

	[Display(Name="posts")]
	public IEnumerable<Guid> Posts { get; set; }

	public IEnumerable<Guid> Friends { get; set; }

	public IEnumerable<Guid> Forbiden { get; set; }
}