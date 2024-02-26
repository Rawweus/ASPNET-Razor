using System.ComponentModel.DataAnnotations;

namespace WebApp.Models;

public class SignInFormModel
{
	[DataType(DataType.EmailAddress)]
	[Display(Name = "Email", Prompt = "Enter your email address")]
	[Required(ErrorMessage = "Enter a valid email address")]

	public string Email { get; set; } = null!;

	[DataType(DataType.Password)]
	[Display(Name = "Password", Prompt = "Enter your password")]
	[Required(ErrorMessage = "Enter a valid password")]

	public string Password { get; set; } = null!;

	[Display(Name = "Remember me")]
	public bool RememberMe { get; set; } = false;
}
