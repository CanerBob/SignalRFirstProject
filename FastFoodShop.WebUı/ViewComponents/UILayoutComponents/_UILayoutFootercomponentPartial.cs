namespace FastFoodShop.WebUı.ViewComponents.UILayoutComponents;
public class _UILayoutFootercomponentPartial:ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;
    public _UILayoutFootercomponentPartial(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7099/api/Contact");
        var jsonData = await responseMessage.Content.ReadAsStringAsync();
        var values = JsonConvert.DeserializeObject<List<ResultContactViewModel>>(jsonData);
        return View(values);
    }
}