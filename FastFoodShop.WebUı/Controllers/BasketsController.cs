namespace FastFoodShop.WebUı.Controllers;
public class BasketsController : Controller
{
	private readonly IHttpClientFactory _httpClientFactory;
	public BasketsController(IHttpClientFactory httpClientFactory)
	{
		_httpClientFactory = httpClientFactory;
	}
	public async Task<IActionResult> Index()
	{
		var client = _httpClientFactory.CreateClient();
		var responseMessage = await client.GetAsync("https://localhost:7099/api/Basket/BasketListByMenuTableWithProductName?id=1");
		if (responseMessage.IsSuccessStatusCode)
		{
			var jsonData = await responseMessage.Content.ReadAsStringAsync();
			var values = JsonConvert.DeserializeObject<List<ResultBasketViewModel>>(jsonData);
			return View(values);
		}
		return View();
	}
	public async Task<IActionResult> DeleteBasket(int id) 
	{
		var client = _httpClientFactory.CreateClient();
		var responseMessage = await client.DeleteAsync($"https://localhost:7099/api/Basket/{id}");
		if (responseMessage.IsSuccessStatusCode)
		{
			return RedirectToAction("Index");
		}
		return NoContent();
	}
}