namespace FastFoodShop.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TestimonialController : ControllerBase
{
	private readonly ITestimonialService _testimonialService;
	private readonly IMapper _mapper;
	public TestimonialController(ITestimonialService testimonialService, IMapper mapper)
	{
		_testimonialService = testimonialService;
		_mapper = mapper;
	}
	[HttpGet]
	public IActionResult GetTestimonials()
	{
		var values = _testimonialService.TGetAllList();
		return Ok(values);
	}
	[HttpPost]
	public IActionResult CreateTestimonial(CreateTestimonialDto model)
	{
		_testimonialService.TAdd(new Testimonial()
		{
			Comment = model.Comment,
			ImageUrl = model.ImageUrl,
			Name = model.Name,
			Status = model.Status,
			Title = model.Title,
		});
		return Ok(model);
	}
	[HttpPut]
	public IActionResult UpdateTestimonial(UpdateTestimonialDto model) 
	{
		_testimonialService.TUpdate(new Testimonial()
		{
			 TestimonialId= model.TestimonialId,
			 Comment = model.Comment,
			 ImageUrl = model.ImageUrl,
			 Name = model.Name,
			 Status = model.Status,
			 Title = model.Title,
		});
		return Ok(model);
	}
	[HttpDelete("{id}")]
	public IActionResult DeleteSocialMedia(int id)
	{
		var item = _testimonialService.TGetById(id);
		_testimonialService.TDelete(item);
		return Ok("Silme İşlemi Başarılı");
	}
	[HttpGet("{id}")]
	public IActionResult GetTestimonial(int id) 
	{
		var item=_testimonialService.TGetById(id);
		return Ok(item);
	}
}