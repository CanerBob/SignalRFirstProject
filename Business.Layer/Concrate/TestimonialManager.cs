namespace Business.Layer.Concrate;
public class TestimonialManager : ITestimonialService
{
	private readonly ITestimonialDal _testiminoalDal;
	public TestimonialManager(ITestimonialDal testiminoalDal)
	{
		_testiminoalDal = testiminoalDal;
	}
	public void TAdd(Testimonial entity)
	{
		_testiminoalDal.Add(entity);
	}
	public void TDelete(Testimonial entity)
	{
		_testiminoalDal.Delete(entity);
	}
	public List<Testimonial> TGetAllList()
	{
		return _testiminoalDal.GetAllList();
	}
	public Testimonial TGetById(int id)
	{
		return _testiminoalDal.GetById(id);
	}
	public void TUpdate(Testimonial entity)
	{
		_testiminoalDal.Update(entity);
	}
}