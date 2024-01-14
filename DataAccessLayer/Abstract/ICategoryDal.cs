namespace DataAccessLayer.Abstract;
public interface ICategoryDal:IGenericDal<Category>
{
	public int CategoryCount();
	public int ActiveCategoryCount();
	public int PassiveCategoryCount();
}