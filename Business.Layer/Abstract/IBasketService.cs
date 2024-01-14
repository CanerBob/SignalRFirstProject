namespace Business.Layer.Abstract;
public interface IBasketService:IGenericService<Basket>
{
	List<Basket> TGetBasketByMenuTableNumber(int id);
}