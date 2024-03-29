﻿namespace FastFoodShop.WebUı.Controllers;
//[AllowAnonymous]
public class LoginController : Controller
{
	private readonly SignInManager<AppUser> _signInManager;
	public LoginController(SignInManager<AppUser> signInManager)
	{
		_signInManager = signInManager;
	}
	[HttpGet]
	public IActionResult Index()
	{
		return View();
	}
	[HttpPost]
	public async Task<IActionResult> Index(LoginViewModel model) 
	{
		var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, false, false);
		if (result.Succeeded) 
		{
			return RedirectToAction("Index", "Category"); 
		}
		return View();
	}
	public async Task<IActionResult> LogOut() 
	{
		await _signInManager.SignOutAsync();
		return RedirectToAction("Index", "Login");
	}
}