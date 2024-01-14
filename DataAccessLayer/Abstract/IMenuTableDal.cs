namespace DataAccessLayer.Abstract;
public interface IMenuTableDal:IGenericDal<MenuTable>
{
	int MenuTableCount();
}