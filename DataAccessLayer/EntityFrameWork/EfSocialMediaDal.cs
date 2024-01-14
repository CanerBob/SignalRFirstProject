namespace DataAccessLayer.EntityFrameWork;
public class EfSocialMediaDal : GenericRepository<SocialMedia>, ISocialMediaDal
{
	public EfSocialMediaDal(AppDbContext appDbContext) : base(appDbContext){}
}