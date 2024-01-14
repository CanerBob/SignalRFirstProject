namespace FastFoodShop.WebUı.ViewComponents.DefaultComponents;
public class _DefaultOurMenuComponentPartial:ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;
    public _DefaultOurMenuComponentPartial(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7099/api/Product");
        var jsonData = await responseMessage.Content.ReadAsStringAsync();
        var values = JsonConvert.DeserializeObject<List<ResultProductViewModel>>(jsonData);
        return View(values);
    }
}