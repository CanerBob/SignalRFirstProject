namespace DataAccessLayer.EntityFrameWork;
public class EfMEssageDal : GenericRepository<Message>, IMessageDal
{
	public EfMEssageDal(AppDbContext appDbContext) : base(appDbContext){}
}