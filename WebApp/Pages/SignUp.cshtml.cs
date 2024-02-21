using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Models;

namespace WebApp.Pages;

public class SignUpModel : PageModel
{
    public string PageTitle { get; set; } = "Sign up";
	[BindProperty]
    public SignUpFormModel Form { get; set; } = new SignUpFormModel();

	// Ladda formul�ret n�r vi g�r till signup-sidan
	public void OnGet()
	{
	}

    // Anv�nds n�r vi har submittad ett formul�r
	public IActionResult OnPost()
	{
		if (!ModelState.IsValid)
		{
			return Page();
		}

		// skicka iv�g formul�ret till en userService f�r registrering...
		// var result = _userService.CreateUser(Form);

		return RedirectToPage("/index");
	}
}
