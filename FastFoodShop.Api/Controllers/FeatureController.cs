namespace FastFoodShop.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class FeatureController : ControllerBase
{
	private readonly IFeatureService _featureService;
	private readonly IMapper _mapper;
	public FeatureController(IFeatureService featureService, IMapper mapper)
	{
		_featureService = featureService;
		_mapper = mapper;
	}
	[HttpGet]
	public IActionResult GetFeature()
	{
		var item = _featureService.TGetAllList();
		return Ok(item);
	}
	[HttpPost]
	public IActionResult CreateFeature(CreateFeatureDto model)
	{
		_featureService.TAdd(new Feature()
		{
			Description1 = model.Description1,
			Description2 = model.Description2,
			Description3 = model.Description3,
			Title1 = model.Title1,
			Title2 = model.Title2,
			Title3 = model.Title3,
		});
		return Ok(model);
	}
	[HttpDelete("{id}")]
	public IActionResult DeleteFeature(int id)
	{
		var item = _featureService.TGetById(id);
		_featureService.TDelete(item);
		return Ok("Silme İşlemi Başarılı");
	}
	[HttpGet("{id}")]
	public IActionResult GetFeature(int id)
	{
		var item = _featureService.TGetById(id);
		return Ok(item);
	}
}