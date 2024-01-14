using Microsoft.AspNetCore.Mvc;
namespace FastFoodShop.WebUı.ViewComponents.LayoutComponents;
public class _layoutFooterComponentPartial : ViewComponent
{
	public IViewComponentResult Invoke()
	{
		return View();
	}
}