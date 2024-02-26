using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models;

public class SignUpFormModel
{
    [Display(Name = "First name", Prompt = "Enter your first name")]
    [Required(ErrorMessage = "Enter a first name")]
	[MinLength(2, ErrorMessage ="Enter a first name")]
    public string FirstName { get; set; } = null!;

	[Display(Name = "Last name", Prompt = "Enter your last name")]
	[Required(ErrorMessage = "Enter a last name")]
	[MinLength(2, ErrorMessage = "Enter a last name")]
	public string LastName { get; set; } = null!;

	[DataType(DataType.EmailAddress)]
	[Display(Name = "Email", Prompt = "Enter your email address")]
	[Required(ErrorMessage = "Enter a valid email address")]
	[RegularExpression(@"^(([^<>()[\]\\.,;:\s@\""]+(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$", ErrorMessage = "Enter a valid email address")]
	public string Email { get; set; } = null!;

	[DataType(DataType.Password)]
	[Display(Name = "Password", Prompt = "Enter your password")]
	[Required(ErrorMessage = "Enter a valid password")]
	[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#\$%\^&\*])(?=.{8,})", ErrorMessage = "Enter a valid password")]
	public string Password { get; set; } = null!;
	
	[DataType(DataType.Password)]
	[Display(Name = "Confirm password", Prompt = "Confirm password")]
	[Required(ErrorMessage = "Password must be confirmed")]
    [Compare(nameof(Password), ErrorMessage = "Passwords do not match")]
    public string ConfirmPassword { get; set; } = null!;

	[Display(Name = "I agree to the Terms & Conditions")]
	[CheckBoxRequired(ErrorMessage ="You must agree to the terms & conditions")]
	[Required(ErrorMessage = "You must agree to the terms & conditions")]
    public bool Terms { get; set; }
}

public class CheckBoxRequired : ValidationAttribute, IClientModelValidator
{
	public override bool IsValid(object? value)
	{
		if (value is bool)
		{
			return (bool)value;
		}

		return false;
	}

	public void AddValidation(ClientModelValidationContext context)
	{
		context.Attributes.Add("data-val-checkboxrequired", FormatErrorMessage(context.ModelMetadata.GetDisplayName()));
	}
}