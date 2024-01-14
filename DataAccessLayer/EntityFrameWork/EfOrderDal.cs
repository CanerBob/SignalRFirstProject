namespace DataAccessLayer.EntityFrameWork;
public class EfOrderDal : GenericRepository<Order>, IOrderDal
{
	public EfOrderDal(AppDbContext appDbContext) : base(appDbContext){}

	public int ActiveOrderCount()
	{
		using var context = new AppDbContext();
		return context.Orders.Where(x => x.Description == "Müşteri Masada").Count();
	}
	public decimal LastOrderPrice()
	{
		using var context=new AppDbContext();
		return context.Orders.OrderByDescending(x => x.OrderId).Take(1).Select(y => y.TotalPrice).FirstOrDefault();
	}

	public decimal TodayTotalPrice()
	{
		//using var context= new AppDbContext();
		//return context.Orders.Where(x => x.Date == DateOnly.Parse(DateOnly.Now.ToShortDateString())).Sum(y => y.TotalPrice);
		return 0;
	}

	public int TotalOrderCount()
	{
		using var context = new AppDbContext();
		return context.Orders.Count();
	}
}