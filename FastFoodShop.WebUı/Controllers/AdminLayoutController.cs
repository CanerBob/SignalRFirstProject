using Microsoft.AspNetCore.Mvc;
namespace FastFoodShop.WebUı.Controllers;
public class AdminLayoutController : Controller
{
	public IActionResult Index()
	{
		return View();
	}
}