namespace FastFoodShop.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class DiscountController : ControllerBase
{
	private readonly IDiscountService _discountService;
	private readonly IMapper _mapper;
	public DiscountController(IDiscountService discountService, IMapper mapper)
	{
		_discountService = discountService;
		_mapper = mapper;
	}
	[HttpGet]
	public IActionResult DiscountList()
	{
		var items = _discountService.TGetAllList();
		return Ok(items);
	}
	[HttpPost]
	public IActionResult CreateDiscount(CreatedDiscountDto model)
	{
		_discountService.TAdd(new Discount()
		{
			Amount = model.Amount,
			Description = model.Description,
			ImageUrl = model.ImageUrl,
			Title = model.Title,
			Status = false
		}) ;
		return Ok("İndirim Başarılı Bir Şekilde Tanımlandı");
	}
	[HttpDelete("{id}")]
	public IActionResult DeleteDiscount(int id)
	{
		var item = _discountService.TGetById(id);
		_discountService.TDelete(item);
		return Ok("Silme İşlemi Başarılı");
	}
	[HttpPut]
	public IActionResult UpdateDiscount(UpdateDiscountDto model)
	{
		_discountService.TUpdate(new Discount()
		{
			DiscountId = model.DiscountId,
			Amount = model.Amount,
			Description = model.Description,
			ImageUrl = model.ImageUrl,
			Title = model.Title,
			Status=false
		});
		return Ok(model);
	}
	[HttpGet("{id}")]
	public IActionResult GetDiscount(int id)
	{
		var item = _discountService.TGetById(id);
		return Ok(item);
	}
	[HttpGet("ChangeStatusToTrue/{id}")]
	public IActionResult ChangeStatusToTrue(int id) 
	{
		_discountService.TChangeStatusToTrue(id);
		return Ok("Ürün İndirim Durumu Aktifleştirildi");
	}
    [HttpGet("ChangeStatusToFalse/{id}")]
    public IActionResult ChangeStatusToFalse(int id)
    {
        _discountService.TChangeStatusToFalse(id);
        return Ok("Ürün İndirim Durumu Pasifleştirildi");
    }
	[HttpGet("GetListByStatusTrue")]
	public IActionResult GetListByStatusTrue() 
	{
		return Ok(_discountService.TGetListByStatusTrue());
	}
}