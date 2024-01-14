namespace FastFoodShop.WebUı.ViewComponents.DefaultComponents;
public class _DefaultCustomerCommentComponentPartial : ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;
    public _DefaultCustomerCommentComponentPartial(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7099/api/Testimonial");
        var jsonData = await responseMessage.Content.ReadAsStringAsync();
        var values = JsonConvert.DeserializeObject<List<ResultTestimonialViewModel>>(jsonData);
        return View(values);
    }
}