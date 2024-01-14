namespace FastFoodShop.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AboutController : ControllerBase
{
	private readonly IAboutService _abuotService;
	public AboutController(IAboutService abuotService)
	{
		_abuotService = abuotService;
	}
	[HttpGet]
	public IActionResult AboutList() 
	{
		var values = _abuotService.TGetAllList();
		return Ok(values);
	}
	[HttpPost]
	public IActionResult CreateAbout(CreateAboutDto model) 
	{
		About about= new About() 
		{
		 Title = model.Title,
		 Description = model.Description,
		 ImageUrl = model.ImageUrl,
		};
		_abuotService.TAdd(about);
		return Ok("Hakkımda Kısmı Başarılı Bir Şekilde Eklendi");
	}
	[HttpDelete("{id}")]
	public IActionResult DeleteAbout(int id) 
	{
	var value= _abuotService.TGetById(id);
		_abuotService.TDelete(value);
		return Ok("Hakkımda Alanı Silindi");
	}
	[HttpPut]
	public IActionResult UpdateAbout(UpdateAboutDto model) 
	{
		About about = new About() 
		{
		 AboutId = model.AboutId,
		 Title = model.Title,
		 Description = model.Description,
		 ImageUrl = model.ImageUrl,
		};
		_abuotService.TUpdate(about);
		return Ok("Hakkımda Alanı Güncellendi");
	}
	[HttpGet("{id}")]
	public IActionResult GetAbout(int id) 
	{
		var value = _abuotService.TGetById(id);
		return Ok(value);
	}
}