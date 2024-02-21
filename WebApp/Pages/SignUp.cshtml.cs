using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Models;

namespace WebApp.Pages;

public class SignUpModel : PageModel
{
    public string PageTitle { get; set; } = "Sign up";
	[BindProperty]
    public SignUpFormModel Form { get; set; } = new SignUpFormModel();

	// Ladda formuläret när vi går till signup-sidan
	public void OnGet()
	{
	}

    // Används när vi har submittad ett formulär
	public IActionResult OnPost()
	{
		if (!ModelState.IsValid)
		{
			return Page();
		}

		// skicka iväg formuläret till en userService för registrering...
		// var result = _userService.CreateUser(Form);

		return RedirectToPage("/index");
	}
}
