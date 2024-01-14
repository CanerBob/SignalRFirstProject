namespace DataAccessLayer.EntityFrameWork;
public class EfBasketDal : GenericRepository<Basket>, IBasketDal
{
	public EfBasketDal(AppDbContext appDbContext) : base(appDbContext){}
	public List<Basket> GetBasketByMenuTableNumber(int id)
	{
		using var context = new AppDbContext();
		var values = context.Baskets.Where(x => x.MenuTableId == id).Include(y=>y.Product).ToList();
		return values;
	}
}