namespace Business.Layer.Abstract;
public interface ICateogoryService:IGenericService<Category>
{
	public int TCategoryCount();
	public int TActiveCategoriesCount();
	public int TPassiveCategoriesCount();
}