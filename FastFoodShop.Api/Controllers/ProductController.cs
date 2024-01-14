namespace FastFoodShop.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
	private readonly IProductService _productService;
	private readonly IMapper _mapper;
	private readonly AppDbContext _appDbContext;
	public ProductController(IProductService productService, IMapper mapper, AppDbContext appDbContext)
	{
		_productService = productService;
		_mapper = mapper;
		_appDbContext = appDbContext;
	}
	[HttpGet]
	public IActionResult GetProducts()
	{
		var items = _productService.TGetAllList();
		return Ok(items);
	}
	[HttpGet("ProductNameMaxPrice")]
	public IActionResult ProductNameMaxPrice() 
	{
		return Ok(_productService.ProductNameByMaxPrice());
	}
	[HttpGet("ProductNameMinPrice")]
	public IActionResult ProductNameMinPrice()
	{
		return Ok(_productService.ProductNameByMinPrice());
	}
	[HttpGet("ProductCount")]
	public IActionResult ProductCount()
	{
		return Ok(_productService.TGetProductCount());
	}
	[HttpGet("CategoryNameHamburger")]
	public IActionResult CategoryNameHamburger() 
	{
		return Ok(_productService.TProductCountByCategoryNameHamburger());
	}
	[HttpGet("CategoryNameDrink")]
	public IActionResult CategoryNameDrink() 
	{
		return Ok(_productService.TProductCountByCategoryNameDrink());
	}
	[HttpGet("ProductPriceAvg")]
	public IActionResult ProductPriceAvg() 
	{
		return Ok(_productService.TProductPriceAvg());
	}
	[HttpGet("ProductListWithCategory")]
	public IActionResult ProductListWithCategory()
	{
		var values = _appDbContext.Products.Include(x => x.Category).Select(z => new ResultProductWithCategory()
		{
			Description = z.Description,
			ImageUrl = z.ImageUrl,
			Price = z.Price,
			ProductId = z.ProductId,
			ProductName = z.ProductName,
			ProductStatus = z.ProductStatus,
			CategoryName = z.Category.CategoryName
		});
		return Ok(values);
	}
	[HttpPost]
	public IActionResult CreateProduct(CreateProductDto model)
	{
		_productService.TAdd(new Product()
		{
			Description = model.Description,
			ImageUrl = model.ImageUrl,
			Price = model.Price,
			ProductName = model.ProductName,
			ProductStatus = model.ProductStatus,
			CategoryId = model.CategoryId
		});
		return Ok(model);
	}
	[HttpPut]
	public IActionResult UpdateProduct(UpdateProductDto model)
	{
		_productService.TUpdate(new Product()
		{
			ProductId = model.ProductId,
			ProductName = model.ProductName,
			ProductStatus = model.ProductStatus,
			Description = model.Description,
			ImageUrl = model.ImageUrl,
			Price = model.Price,
			CategoryId = model.CategoryId
		});
		return Ok(model);
	}
	[HttpDelete("{id}")]
	public IActionResult DeleteProduct(int id)
	{
		var item = _productService.TGetById(id);
		_productService.TDelete(item);
		return Ok("Silme İşlemi Başarılı");
	}
	[HttpGet("{id}")]
	public IActionResult GetProduct(int id)
	{
		var item = _productService.TGetById(id);
		return Ok(item);
	}
}