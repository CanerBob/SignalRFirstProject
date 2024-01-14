namespace DataAccessLayer.EntityFrameWork;
public class EfFeatureDal : GenericRepository<Feature>, IFeatureDal
{
	public EfFeatureDal(AppDbContext appDbContext) : base(appDbContext){}
}