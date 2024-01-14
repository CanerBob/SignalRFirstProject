using Microsoft.AspNetCore.Mvc;
namespace FastFoodShop.WebUı.ViewComponents.LayoutComponents;
public class _layoutScriptComponentPartial : ViewComponent
{
	public IViewComponentResult Invoke()
	{
		return View();
	}
}