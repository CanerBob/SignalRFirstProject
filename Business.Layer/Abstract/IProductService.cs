namespace Business.Layer.Abstract;
public interface IProductService:IGenericService<Product>
{
	List<Product> TGetProductWithCategory();
	public int TGetProductCount();
	int TProductCountByCategoryNameHamburger();
	int TProductCountByCategoryNameDrink();
	decimal TProductPriceAvg();
	string ProductNameByMaxPrice();
	string ProductNameByMinPrice();
}