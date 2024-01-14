namespace DataAccessLayer.EntityFrameWork;
public class EfTestimonialDal : GenericRepository<Testimonial>, ITestimonialDal
{
	public EfTestimonialDal(AppDbContext appDbContext) : base(appDbContext){}
}