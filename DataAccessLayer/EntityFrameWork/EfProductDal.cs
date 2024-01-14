namespace DataAccessLayer.EntityFrameWork;
public class EfProductDal : GenericRepository<Product>, IProductDal
{
	public EfProductDal(AppDbContext appDbContext) : base(appDbContext){}

	public int GetProductCount()
	{
		using var context = new AppDbContext();
		return context.Products.Count();
	}
	public List<Product> GetProductWithCategory()
	{
		var context = new AppDbContext();
		var values= context.Products.Include(x=>x.Category).ToList(); 
		return values;
	} 
	public int ProductCountByCategoryNameDrink()
	{
		using var context= new AppDbContext();
		return context.Products.Where(x=>x.Category.CategoryName=="İçecek").Count();
	}
	public int ProductCountByCategoryNameHamburger()
	{
		using var context=new AppDbContext();
		return context.Products.Where(x => x.Category.CategoryName == "Hamburger").Count();
	}
	public string ProductNameByMaxPrice()
	{
		using var context = new AppDbContext();
		return context.Products.Where(x => x.Price == (context.Products.Max(y => y.Price))).Select(z => z.ProductName).FirstOrDefault();
	}
	public string ProductNameByMinPrice()
	{
		using var context = new AppDbContext();
		return context.Products.Where(x => x.Price == (context.Products.Min(y => y.Price))).Select(z => z.ProductName).FirstOrDefault();
	}
	public decimal ProductPriceAvg()
	{
		using var context = new AppDbContext();
		return context.Products.Average(x=>x.Price);
	}
}