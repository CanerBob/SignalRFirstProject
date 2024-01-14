﻿namespace FastFoodShop.WebUı.Controllers;
public class SocialMediaController : Controller
{
	private readonly IHttpClientFactory _httpClientFactory;
	public SocialMediaController(IHttpClientFactory httpClientFactory)
	{
		_httpClientFactory = httpClientFactory;
	}
	public async Task<IActionResult> Index()
	{
		var client = _httpClientFactory.CreateClient();
		var responseMessage = await client.GetAsync("https://localhost:7099/api/SocialMedia");
		if (responseMessage.IsSuccessStatusCode)
		{
			var jsonData = await responseMessage.Content.ReadAsStringAsync();
			var values = JsonConvert.DeserializeObject<List<ResultSocialMediaViewModel>>(jsonData);
			return View(values);
		}
		return View();
	}
	[HttpGet]
	public IActionResult CreateSocialMedia()
	{
		return View();
	}
	[HttpPost]
	public async Task<IActionResult> CreateSocialMedia(CreateSocialMediaViewModel model)
	{
		var client = _httpClientFactory.CreateClient();
		var jsonData = JsonConvert.SerializeObject(model);
		StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
		var responseMessage = await client.PostAsync("https://localhost:7099/api/SocialMedia", stringContent);
		if (responseMessage.IsSuccessStatusCode)
		{
			return RedirectToAction("Index");
		}
		return View();
	}
	public async Task<IActionResult> DeleteSocialMedia(int id)
	{
		var client = _httpClientFactory.CreateClient();
		var responseMessage = await client.DeleteAsync($"https://localhost:7099/api/SocialMedia/{id}");
		if (responseMessage.IsSuccessStatusCode)
		{
			return RedirectToAction("Index");
		}
		return View();
	}
	public async Task<IActionResult> UpdateSocialMedia(int id)
	{
		var client = _httpClientFactory.CreateClient();
		var responseMessage = await client.GetAsync($"https://localhost:7099/api/SocialMedia/{id}");
		if (responseMessage.IsSuccessStatusCode)
		{
			var jsonData = await responseMessage.Content.ReadAsStringAsync();
			var values = JsonConvert.DeserializeObject<UpdateSocialMediaViewModel>(jsonData);
			return View(values);
		}
		return View();
	}
	[HttpPost]
	public async Task<IActionResult> UpdateSocialMedia(UpdateSocialMediaViewModel model)
	{
		var client = _httpClientFactory.CreateClient();
		var jsonData = JsonConvert.SerializeObject(model);
		StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
		var responseMessage = await client.PutAsync("https://localhost:7099/api/SocialMedia/", stringContent);
		if (responseMessage.IsSuccessStatusCode)
		{
			return RedirectToAction("Index");
		}
		return View();
	}
}