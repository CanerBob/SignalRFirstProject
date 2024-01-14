using Microsoft.AspNetCore.Mvc;

namespace FastFoodShop.WebUı.ViewComponents.LayoutComponents;
public class _layoutSidebarComponentPartial : ViewComponent
{
	public IViewComponentResult Invoke()
	{
		return View();
	}
}
