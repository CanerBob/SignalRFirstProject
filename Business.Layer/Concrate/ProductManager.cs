namespace Business.Layer.Concrate;
public class ProductManager : IProductService
{
	private readonly IProductDal _productDal;
	private readonly AppDbContext _appDbContext;

	public ProductManager(IProductDal productDal, AppDbContext appDbContext)
	{
		_productDal = productDal;
		_appDbContext = appDbContext;
	}
	public List<Product> TGetProductWithCategory()
	{
		return _productDal.GetProductWithCategory();
	}
	public void TAdd(Product entity)
	{
		_productDal.Add(entity);
	}
	public void TDelete(Product entity)
	{
		_productDal.Delete(entity);
	}
	public List<Product> TGetAllList()
	{
		return _productDal.GetAllList();
	}
	public Product TGetById(int id)
	{
		return _productDal.GetById(id);
	}
	public void TUpdate(Product entity)
	{
		_productDal.Update(entity);
	}

	public int TGetProductCount()
	{
		return _productDal.GetProductCount();
	}
	public int TProductCountByCategoryNameHamburger()
	{
		return _productDal.ProductCountByCategoryNameHamburger();
	}
	public int TProductCountByCategoryNameDrink()
	{
		return _productDal.ProductCountByCategoryNameDrink();
	}
	public decimal TProductPriceAvg()
	{
		return _productDal.ProductPriceAvg();
	}
	public string ProductNameByMaxPrice()
	{
		return _productDal.ProductNameByMaxPrice();
	}
	public string ProductNameByMinPrice()
	{
		return _productDal.ProductNameByMinPrice();
	}
}