namespace DataAccessLayer.EntityFrameWork;
public class EfMenuTableDal : GenericRepository<MenuTable>, IMenuTableDal
{
	public EfMenuTableDal(AppDbContext appDbContext) : base(appDbContext){}

	public int MenuTableCount()
	{
		using var context = new AppDbContext();
		return context.MenuTables.Count();
	}
}