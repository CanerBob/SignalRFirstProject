namespace DataAccessLayer.EntityFrameWork;
public class EfOrderDetailDal : GenericRepository<OrderDetails>, IOrderDetailDal
{
	public EfOrderDetailDal(AppDbContext appDbContext) : base(appDbContext){}
}