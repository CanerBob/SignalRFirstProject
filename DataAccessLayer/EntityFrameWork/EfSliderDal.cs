namespace DataAccessLayer.EntityFrameWork;
public class EfSliderDal : GenericRepository<Slider>, ISliderDal
{
    public EfSliderDal(AppDbContext appDbContext) : base(appDbContext){}
}