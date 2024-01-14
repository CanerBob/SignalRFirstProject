
namespace DataAccessLayer.EntityFrameWork;
public class EfDiscontDal : GenericRepository<Discount>, IDiscountDal
{
	public EfDiscontDal(AppDbContext appDbContext) : base(appDbContext){}
    public void ChangeStatusFalse(int id)
    {
        using var context = new AppDbContext();
        var value = context.Discount.Find(id);
        value.Status = false;
        context.SaveChanges();
    }
    public void ChangeStatusTrue(int id)
    {
        using var context = new AppDbContext();
        var value = context.Discount.Find(id);
        value.Status = true;
        context.SaveChanges();
    }
	public List<Discount> GetListByStatusFalse()
	{
		using var context= new AppDbContext();
        var value=context.Discount.Where(x => x.Status == false).ToList();
        return value;
	}
	public List<Discount> GetListByStatusTrue()
	{
		using var context = new AppDbContext();
		var value = context.Discount.Where(x => x.Status == true).ToList();
		return value;
	}
}