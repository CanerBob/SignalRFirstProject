namespace DataAccessLayer.EntityFrameWork;
public class EfMoneyCasesDal : GenericRepository<MoneyCase>, IMoneyCaseDal
{
	public EfMoneyCasesDal(AppDbContext appDbContext) : base(appDbContext){}

	public decimal TotalMoneyCaseAmount()
	{
		using var context = new AppDbContext();
		return context.MoneyCases.Select(x => x.TatolAmount).FirstOrDefault();
	}
}