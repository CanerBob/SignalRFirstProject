using Microsoft.AspNetCore.Mvc;

namespace FastFoodShop.WebUı.ViewComponents.LayoutComponents;
public class _layoutHeaderComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}