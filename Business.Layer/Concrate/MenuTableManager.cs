namespace Business.Layer.Concrate;
public class MenuTableManager : IMenuTableService
{
	private readonly IMenuTableDal _menuTableDal;
	public MenuTableManager(IMenuTableDal menuTableDal)
	{
		_menuTableDal = menuTableDal;
	}
	public void TAdd(MenuTable entity)
	{
		_menuTableDal.Add(entity);
	}
	public void TDelete(MenuTable entity)
	{
		_menuTableDal.Delete(entity);
	}
	public List<MenuTable> TGetAllList()
	{
		return _menuTableDal.GetAllList();
	}
	public MenuTable TGetById(int id)
	{
		return _menuTableDal.GetById(id);
	}
	public int TMenuTableCount()
	{
		return _menuTableDal.MenuTableCount();
	}
	public void TUpdate(MenuTable entity)
	{
		_menuTableDal.Update(entity);
	}
}