namespace FastFoodShop.WebUı.ViewComponents.DefaultComponents;
public class _DefaultOfferComponentPartial:ViewComponent
{
	private readonly IHttpClientFactory _httpClientFactory;
	public _DefaultOfferComponentPartial(IHttpClientFactory httpClientFactory)
	{
		_httpClientFactory = httpClientFactory;
	}
	public async Task<IViewComponentResult> InvokeAsync()
	{
		var client = _httpClientFactory.CreateClient();
		var responseMessage = await client.GetAsync("https://localhost:7099/api/Discount/GetListByStatusTrue");
		var jsonData = await responseMessage.Content.ReadAsStringAsync();
		var values = JsonConvert.DeserializeObject<List<ResultDiscountViewModel>>(jsonData);
		return View(values);
	}
}