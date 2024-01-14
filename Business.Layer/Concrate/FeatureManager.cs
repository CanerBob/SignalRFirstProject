namespace Business.Layer.Concrate;
public class FeatureManager : IFeatureService
{
	private readonly IFeatureDal _featureDal;
	public FeatureManager(IFeatureDal featureDal)
	{
		_featureDal = featureDal;
	}
	public void TAdd(Feature entity)
	{
		_featureDal.Add(entity);
	}
	public void TDelete(Feature entity)
	{
		_featureDal.Delete(entity);
	}
	public List<Feature> TGetAllList()
	{
		return _featureDal.GetAllList();
	}
	public Feature TGetById(int id)
	{
		return _featureDal.GetById(id);
	}
	public void TUpdate(Feature entity)
	{
		_featureDal.Update(entity);
	}
}