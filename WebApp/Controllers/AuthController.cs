/*

using Microsoft.AspNetCore.Mvc;
using WebApp.ViewModels;

namespace WebApp.Controllers;

public class AuthController : Controller
{
	[HttpGet]
	[Route("/signup")]

	public IActionResult SignUp() => View(new SignUpViewModel());

	[HttpPost]
	[Route("/signup")]

	public IActionResult SignUp(SignUpViewModel viewModel)
	{
		if (!ModelState.IsValid)
		{
			return View(viewModel);
		}
		return RedirectToAction("Index", "Home");
	}
}
*/