namespace DataAccessLayer.Abstract;
public interface IProductDal:IGenericDal<Product>
{
	List<Product> GetProductWithCategory();
	public int GetProductCount();
	int ProductCountByCategoryNameHamburger();
	int ProductCountByCategoryNameDrink();
	decimal ProductPriceAvg();
	string ProductNameByMaxPrice();
	string ProductNameByMinPrice();
}