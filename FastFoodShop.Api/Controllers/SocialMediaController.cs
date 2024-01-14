using Dtos.Layer.SocialMediaDto;

namespace FastFoodShop.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class SocialMediaController : ControllerBase
{
	private readonly ISocialMediaService _service;
	private readonly IMapper _mapper;
	public SocialMediaController(ISocialMediaService service, IMapper mapper)
	{
		_service = service;
		_mapper = mapper;
	}
	[HttpGet]
	public IActionResult GetSocialMedia()
	{
		var items = _service.TGetAllList();
		return Ok(items);
	}
	[HttpPost]
	public IActionResult CreateSocialMedia(CreateSocialMediaDto model)
	{
		_service.TAdd(new SocialMedia()
		{
			Title = model.Title,
			Url = model.Url,
			Icon = model.Icon,
		});
		return Ok(model);
	}
	[HttpPut]
	public IActionResult UpdateSocialMedia(UpdateSocialMediaDto model)
	{
		_service.TUpdate(new SocialMedia()
		{
			SocialMediaId = model.SocialMediaId,
			Title = model.Title,
			Url = model.Url,
			Icon = model.Icon,
		});
		return Ok(model);
	}
	[HttpDelete("{id}")]
	public IActionResult DeleteSocialMedia(int id)
	{
		var item = _service.TGetById(id);
		_service.TDelete(item);
		return Ok("Silme İşlemi Başarılı");
	}
	[HttpGet("{id}")]
	public IActionResult GetSocialMedia(int id)
	{
		var item = _service.TGetById(id);
		return Ok(item);
	}
}