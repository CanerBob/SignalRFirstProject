namespace FastFoodShop.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
	private readonly ICateogoryService _cateogoryService;
	private readonly IMapper _mapper;

	public CategoryController(ICateogoryService cateogoryService, IMapper mapper)
	{
		_cateogoryService = cateogoryService;
		_mapper = mapper;
	}
	[HttpGet]
	public IActionResult CategoryList()
	{
		var values = _mapper.Map<List<ResultCategoryDto>>(_cateogoryService.TGetAllList());
		return Ok(values);
	}
	[HttpGet("CategoryCount")]
	public IActionResult CategoryCount()
	{
		return Ok(_cateogoryService.TCategoryCount());
	}
	[HttpGet("ActiveCategoriesCount")]
	public IActionResult ActiveCategoriesCount()
	{
		return Ok(_cateogoryService.TActiveCategoriesCount());
	}
	[HttpGet("PassiveCategoryCount")]
	public IActionResult PassiveCategoryCount()
	{
		return Ok(_cateogoryService.TPassiveCategoriesCount());
	}
	[HttpPost]
	public IActionResult CreateCategory(CreateCategoryDto model)
	{
		_cateogoryService.TAdd(new Category()
		{
			CategoryName = model.CategoryName,
			Status = true
		});
		return Ok("Kategori Eklendi");
	}
	[HttpDelete("{id}")]
	public IActionResult DeleteCategory(int id)
	{
		var item = _cateogoryService.TGetById(id);
		_cateogoryService.TDelete(item);
		return Ok("Silme İşlemi Başarılı");
	}
	[HttpGet("{id}")]
	public IActionResult GetCategory(int id)
	{
		var item = _cateogoryService.TGetById(id);
		return Ok(item);
	}
	[HttpPut]
	public IActionResult UpdateCategory(UpdateCategoryDto model)
	{
		_cateogoryService.TUpdate(new Category()
		{
			CategoryId = model.CategoryId,
			Status = model.Status,
			CategoryName = model.CategoryName
		});
		return Ok("Kategori Güncellendi");
	}
}