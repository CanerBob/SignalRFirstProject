namespace FastFoodShop.WebUı.Controllers;
public class ReservationController : Controller
{
	private readonly IHttpClientFactory _httpClientFactory;
	public ReservationController(IHttpClientFactory httpClientFactory)
	{
		_httpClientFactory = httpClientFactory;
	}
	public async Task<IActionResult> Index()
	{
		var client = _httpClientFactory.CreateClient();
		var responseMessage = await client.GetAsync("https://localhost:7099/api/Reservation");
		if (responseMessage.IsSuccessStatusCode)
		{
			var jsonData = await responseMessage.Content.ReadAsStringAsync();
			var values = JsonConvert.DeserializeObject<List<ResultReservationViewModel>>(jsonData);
			return View(values);
		}
		return View();
	}
	[HttpGet]
	public IActionResult CreateReservation()
	{
		return View();
	}
	[HttpPost]
	public async Task<IActionResult> CreateReservation(CreateReservationViewModel model)
	{
		model.Description = "Rezervasyon Alındı";
		var client = _httpClientFactory.CreateClient();
		var jsonData = JsonConvert.SerializeObject(model);
		StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
		var responseMessage = await client.PostAsync("https://localhost:7099/api/Reservation", stringContent);
		if (responseMessage.IsSuccessStatusCode)
		{
			return RedirectToAction("Index");
		}
		return View();
	}
	public async Task<IActionResult> DeleteReservation(int id)
	{
		var client = _httpClientFactory.CreateClient();
		var responseMessage = await client.DeleteAsync($"https://localhost:7099/api/Reservation/{id}");
		if (responseMessage.IsSuccessStatusCode)
		{
			return RedirectToAction("Index");
		}
		return View();
	}
	public async Task<IActionResult> UpdateReservation(int id)
	{
		var client = _httpClientFactory.CreateClient();
		var responseMessage = await client.GetAsync($"https://localhost:7099/api/Reservation/{id}");
		if (responseMessage.IsSuccessStatusCode)
		{
			var jsonData = await responseMessage.Content.ReadAsStringAsync();
			var values = JsonConvert.DeserializeObject<UpdateReservationViewModel>(jsonData);
			return View(values);
		}
		return View();
	}
	[HttpPost]
	public async Task<IActionResult> UpdateReservation(UpdateReservationViewModel model)
	{
		var client = _httpClientFactory.CreateClient();
		var jsonData = JsonConvert.SerializeObject(model);
		StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
		var responseMessage = await client.PutAsync("https://localhost:7099/api/Reservation/", stringContent);
		if (responseMessage.IsSuccessStatusCode)
		{
			return RedirectToAction("Index");
		}
		return View();
	}
	public async Task<IActionResult> ReservationStatusApproved(int id) 
	{
		var client = _httpClientFactory.CreateClient();
		await client.GetAsync($"https://localhost:7099/api/Reservation/ReservationStatusApproved/{id}");
		return RedirectToAction("Index");
	}
	public async Task<IActionResult> ReservationStatusCanceled(int id)
	{
		var client = _httpClientFactory.CreateClient();
		await client.GetAsync($"https://localhost:7099/api/Reservation/ReservationStatusApproved/{id}");
		return RedirectToAction("Index");
	}
}