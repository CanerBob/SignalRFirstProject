namespace Business.Layer.Concrate;
public class SocialMediaManager : ISocialMediaService
{
	private readonly ISocialMediaDal _socialmediaDal;
	public SocialMediaManager(ISocialMediaDal socialmediaDal)
	{
		_socialmediaDal = socialmediaDal;
	}
	public void TAdd(SocialMedia entity)
	{
		_socialmediaDal.Add(entity);
	}
	public void TDelete(SocialMedia entity)
	{
		_socialmediaDal.Delete(entity);
	}
	public List<SocialMedia> TGetAllList()
	{
		return _socialmediaDal.GetAllList();
	}
	public SocialMedia TGetById(int id)
	{
		return _socialmediaDal.GetById(id);
	}
	public void TUpdate(SocialMedia entity)
	{
		_socialmediaDal.Update(entity);
	}
}