namespace DataAccessLayer.EntityFrameWork;
public class EfContactDal : GenericRepository<Contact>, IContactDal
{
	public EfContactDal(AppDbContext appDbContext) : base(appDbContext){}
}