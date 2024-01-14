namespace FastFoodShop.WebUı.Controllers;
public class CategoryController : Controller
{
	private readonly IHttpClientFactory _httpClientFactory;
	public CategoryController(IHttpClientFactory httpClientFactory)
	{
		_httpClientFactory = httpClientFactory;
	}
	public async Task<IActionResult> Index()
	{
		var client = _httpClientFactory.CreateClient();
		var responseMessage = await client.GetAsync("https://localhost:7099/api/Category");
		if (responseMessage.IsSuccessStatusCode)
		{
			var jsonData = await responseMessage.Content.ReadAsStringAsync();
			var values = JsonConvert.DeserializeObject<List<ResultCategoryViewModel>>(jsonData);
			return View(values);
		}
		return View();
	}
	[HttpGet]
	public IActionResult CreateCategory()
	{
		return View();
	}
	[HttpPost]
	public async Task<IActionResult> CreateCategory(CreateCategoryViewModel model)
	{
		model.Status = true;
		var client = _httpClientFactory.CreateClient();
		var jsonData = JsonConvert.SerializeObject(model);
		StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
		var responseMessage = await client.PostAsync("https://localhost:7099/api/Category", stringContent);
		if (responseMessage.IsSuccessStatusCode)
		{
			return RedirectToAction("Index");
		}
		return View();
	}
	public async Task<IActionResult> DeleteCategory(int id)
	{
		var client = _httpClientFactory.CreateClient();
		var responseMessage = await client.DeleteAsync($"https://localhost:7099/api/Category/{id}");
		if (responseMessage.IsSuccessStatusCode)
		{
			return RedirectToAction("Index");
		}
		return View();
	}
	public async Task<IActionResult> UpdateCategory(int id)
	{
		var client = _httpClientFactory.CreateClient();
		var responseMessage = await client.GetAsync($"https://localhost:7099/api/Category/{id}");
		if (responseMessage.IsSuccessStatusCode)
		{
			var jsonData = await responseMessage.Content.ReadAsStringAsync();
			var values = JsonConvert.DeserializeObject<UpdateCategoryViewModel>(jsonData);
			return View(values);
		}
		return View();
	}
	[HttpPost]
	public async Task<IActionResult> UpdateCategory(UpdateCategoryViewModel model)
	{
		var client = _httpClientFactory.CreateClient();
		var jsonData = JsonConvert.SerializeObject(model);
		StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
		var responseMessage = await client.PutAsync("https://localhost:7099/api/Category/", stringContent);
		if (responseMessage.IsSuccessStatusCode)
		{
			return RedirectToAction("Index");
		}
		return View();
	}
}