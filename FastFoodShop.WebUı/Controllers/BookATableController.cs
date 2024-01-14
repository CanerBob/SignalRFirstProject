namespace FastFoodShop.WebUı.Controllers;
public class BookATableController : Controller
{
	private readonly IHttpClientFactory _httpClientFactory;
    public BookATableController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }
    [HttpGet]
    public IActionResult Index()
	{
		return View();
	}
    [HttpPost]
    public async Task<IActionResult> Index(CreateReservationViewModel model)
    {
        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(model);
        StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var responseMessage = await client.PostAsync("https://localhost:7099/api/Reservation", stringContent);
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index","Default");
        }
        return View();
    }
}