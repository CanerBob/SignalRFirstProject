using Microsoft.AspNetCore.Mvc;
namespace FastFoodShop.WebUı.ViewComponents.LayoutComponents;
public class _layoutNavbarComponentPartial : ViewComponent
{
	public IViewComponentResult Invoke()
	{
		return View();
	}
}