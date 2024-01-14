using System.Net.Http;

namespace FastFoodShop.WebUı.Controllers;
public class DefaultController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;
	public DefaultController(IHttpClientFactory httpClientFactory)
	{
		_httpClientFactory = httpClientFactory;
	}
	public IActionResult Index()
    {
        return View();
    }
    [HttpGet]
    public PartialViewResult SendMessage() 
    {
        return PartialView();
    }
    [HttpPost]
    public async Task<IActionResult> SendMessage(CreateMessageViewModel model) 
    {
		var client = _httpClientFactory.CreateClient();
		var jsonData = JsonConvert.SerializeObject(model);
		StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
		var responseMessage = await client.PostAsync("https://localhost:7099/api/Message", stringContent);
		if (responseMessage.IsSuccessStatusCode)
		{
			return RedirectToAction("Index");
		}
		return View();
    }
}