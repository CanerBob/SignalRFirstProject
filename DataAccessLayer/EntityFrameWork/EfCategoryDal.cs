namespace DataAccessLayer.EntityFrameWork;
public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
{
	public EfCategoryDal(AppDbContext appDbContext) : base(appDbContext){}

	public int ActiveCategoryCount()
	{
		using var context = new AppDbContext();
		return context.Categories.Where(x => x.Status == true).Count();
	}
	public int CategoryCount()
	{
		using var context = new AppDbContext();
		return context.Categories.Count();
	}
	public int PassiveCategoryCount()
	{
		using var context=new AppDbContext();
		return context.Categories.Where(x => x.Status == false).Count();
	}
}