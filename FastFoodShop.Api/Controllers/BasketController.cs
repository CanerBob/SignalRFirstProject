namespace FastFoodShop.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BasketController : ControllerBase
{
	private readonly IBasketService _basketService;
	public BasketController(IBasketService basketService)
	{
		_basketService = basketService;
	}
	[HttpGet]
	public IActionResult GetBasketByMenuTableId(int id)
	{
		var values = _basketService.TGetBasketByMenuTableNumber(id);
		return Ok(values);
	}
	[HttpGet("BasketListByMenuTableWithProductName")]
	public IActionResult BasketListByMenuTableWithProductName(int id)
	{
		using var context = new AppDbContext();
		var values = context.Baskets.Include(x => x.Product).Where(y => y.MenuTableId == id)
			.Select(b => new ResultBasketListWithProduct
			{
				MenuTableId = b.MenuTableId,
				Count = b.Count,
				Id = b.Id,
				Price = b.Price,
				ProductName = b.Product.ProductName,
				TotalPrice = b.TotalPrice,
				ProductId = b.ProductId
			}).ToList();
		return Ok(values);
	}
	[HttpPost]
	public IActionResult CreateBasket(CreateBasketDto model)
	{
		using var context = new AppDbContext();
		_basketService.TAdd(new Basket()
		{
			ProductId = model.ProductId,
			Count = 1,
			MenuTableId = 1,
			Price = context.Products.Where(x => x.ProductId == model.ProductId).Select(y => y.Price).FirstOrDefault(),
			TotalPrice = 0,
		});
		return Ok();
	}
	[HttpDelete("{id=}")]
	public IActionResult DeleteBasket(int id)
	{
		var value=_basketService.TGetById(id);
		_basketService.TDelete(value);
		return Ok("Sepete Eklenen Ürün Silindi");
	}
}