namespace Business.Layer.Concrate;
public class CategoryManager : ICateogoryService
{
	private readonly ICategoryDal _categoryDal;

	public CategoryManager(ICategoryDal categoryDal)
	{
		_categoryDal = categoryDal;
	}
	public int TCategoryCount()
	{
		return _categoryDal.CategoryCount();
	}

	public void TAdd(Category entity)
	{
		_categoryDal.Add(entity);
	}
	public void TDelete(Category entity)
	{
		_categoryDal.Delete(entity);
	}
	public List<Category> TGetAllList()
	{
		return _categoryDal.GetAllList();
	}
	public Category TGetById(int id)
	{
		return _categoryDal.GetById(id);
	}
	public void TUpdate(Category entity)
	{
		_categoryDal.Update(entity);
	}

	public int TActiveCategoriesCount()
	{
		return _categoryDal.ActiveCategoryCount();
	}
	public int TPassiveCategoriesCount()
	{
		return _categoryDal.PassiveCategoryCount();
	}
}