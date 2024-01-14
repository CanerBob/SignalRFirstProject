namespace FastFoodShop.WebUı.Controllers;
public class DiscountController : Controller
{
	private readonly IHttpClientFactory _httpClientFactory;
	public DiscountController(IHttpClientFactory httpClientFactory)
	{
		_httpClientFactory = httpClientFactory;
	}
	public async Task<IActionResult> Index()
	{
		var client = _httpClientFactory.CreateClient();
		var responseMessage = await client.GetAsync("https://localhost:7099/api/Discount");
		if (responseMessage.IsSuccessStatusCode)
		{
			var jsonData = await responseMessage.Content.ReadAsStringAsync();
			var values = JsonConvert.DeserializeObject<List<ResultDiscountViewModel>>(jsonData);
			return View(values);
		}
		return View();
	}
	[HttpGet]
	public IActionResult CreateDiscount()
	{
		return View();
	}
	[HttpPost]
	public async Task<IActionResult> CreateDiscount(CreateDiscountViewModel model)
	{
		var client = _httpClientFactory.CreateClient();
		var jsonData = JsonConvert.SerializeObject(model);
		StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
		var responseMessage = await client.PostAsync("https://localhost:7099/api/Discount", stringContent);
		if (responseMessage.IsSuccessStatusCode)
		{
			return RedirectToAction("Index");
		}
		return View();
	}
	public async Task<IActionResult> DeleteDiscount(int id)
	{
		var client = _httpClientFactory.CreateClient();
		var responseMessage = await client.DeleteAsync($"https://localhost:7099/api/Discount/{id}");
		if (responseMessage.IsSuccessStatusCode)
		{
			return RedirectToAction("Index");
		}
		return View();
	}
	public async Task<IActionResult> UpdateDiscount(int id)
	{
		var client = _httpClientFactory.CreateClient();
		var responseMessage = await client.GetAsync($"https://localhost:7099/api/Discount/{id}");
		if (responseMessage.IsSuccessStatusCode)
		{
			var jsonData = await responseMessage.Content.ReadAsStringAsync();
			var values = JsonConvert.DeserializeObject<UpdateDiscountViewModel>(jsonData);
			return View(values);
		}
		return View();
	}
	[HttpPost]
	public async Task<IActionResult> UpdateDiscount(UpdateDiscountViewModel model)
	{
		var client = _httpClientFactory.CreateClient();
		var jsonData = JsonConvert.SerializeObject(model);
		StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
		var responseMessage = await client.PutAsync("https://localhost:7099/api/Discount/", stringContent);
		if (responseMessage.IsSuccessStatusCode)
		{
			return RedirectToAction("Index");
		}
		return View();
	}
    public async Task<IActionResult> ChandeStatusToTrue(int id)
    {
        var client = _httpClientFactory.CreateClient();
        await client.GetAsync($"https://localhost:7099/api/Discount/ChangeStatusToTrue/{id}");
		return RedirectToAction("Index");
    }
    public async Task<IActionResult> ChandeStatusToFalse(int id)
    {
        var client = _httpClientFactory.CreateClient();
        await client.GetAsync($"https://localhost:7099/api/Discount/ChangeStatusToFalse/{id}");
        return RedirectToAction("Index");
    }
}