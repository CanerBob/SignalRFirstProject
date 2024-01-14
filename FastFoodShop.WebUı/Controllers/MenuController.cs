namespace FastFoodShop.WebUı.Controllers;
public class MenuController : Controller
{
	private readonly IHttpClientFactory _httpClientFactory;
	public MenuController(IHttpClientFactory httpClientFactory)
	{
		_httpClientFactory = httpClientFactory;
	}
	public async Task<IActionResult> Index()
	{
		var client = _httpClientFactory.CreateClient();
		var responseMessage = await client.GetAsync("https://localhost:7099/api/Product");
		var jsonData = await responseMessage.Content.ReadAsStringAsync();
		var values = JsonConvert.DeserializeObject<List<ResultProductViewModel>>(jsonData);
		return View(values);
	}
	[HttpPost]
	public async Task<IActionResult> AddBasket(int id)
	{
		CreateBasketViewModel createBasketViewModel = new CreateBasketViewModel();
		createBasketViewModel.ProductId = id;
		var client = _httpClientFactory.CreateClient();
		var jsonData = JsonConvert.SerializeObject(createBasketViewModel);
		StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
		var responseMessage = await client.PostAsync("https://localhost:7099/api/Basket", stringContent);
		if (responseMessage.IsSuccessStatusCode)
		{
			return RedirectToAction("Index");
		}
		return Json(createBasketViewModel);
	}
}