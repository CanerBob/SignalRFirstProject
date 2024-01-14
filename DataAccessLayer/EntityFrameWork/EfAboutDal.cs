namespace DataAccessLayer.EntityFrameWork;
public class EfAboutDal : GenericRepository<About>, IAboutDal
{
	public EfAboutDal(AppDbContext appDbContext) : base(appDbContext){}
}