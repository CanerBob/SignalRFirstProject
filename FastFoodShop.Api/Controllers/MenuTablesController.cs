namespace FastFoodShop.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class MenuTablesController : ControllerBase
{
	private readonly IMenuTableService _menuTableService;

	public MenuTablesController(IMenuTableService menuTableService)
	{
		_menuTableService = menuTableService;
	}
	[HttpGet("MenuTableCount")]
	public IActionResult MenuTableCount() 
	{
		return Ok(_menuTableService.TMenuTableCount());
	}
	[HttpGet]
	public IActionResult MenuTableList()
	{
		var values = _menuTableService.TGetAllList();
		return Ok(values);
	}
	[HttpPost]
	public IActionResult CreateMenuTable(CreateMenuTableDto model)
	{
		MenuTable menuTable = new MenuTable()
		{
			  Name = model.Name,
			  Status = false
		};
		_menuTableService.TAdd(menuTable);
		return Ok("Masa Ekleme Başarılı Bir Şekilde Yapıldı");
	}
	[HttpDelete("{id}")]
	public IActionResult DeleteMenuTable(int id)
	{
		var value = _menuTableService.TGetById(id);
		_menuTableService.TDelete(value);
		return Ok("Masa Başarılır Şekilde Silindi");
	}
	[HttpPut]
	public IActionResult UpdateMenuTable(UpdateMenuTableDto model)
	{
		MenuTable menuTable = new MenuTable()
		{
			 Id= model.Id,
			 Name = model.Name,
			 Status = false
		};
		_menuTableService.TUpdate(menuTable);
		return Ok("Masa Güncellendi");
	}
	[HttpGet("{id}")]
	public IActionResult GetMenuTable(int id)
	{
		var value = _menuTableService.TGetById(id);
		return Ok(value);
	}
}