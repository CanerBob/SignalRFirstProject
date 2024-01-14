namespace Business.Layer.Abstract;
public interface IOrderService:IGenericService<Order>
{
	int TTotalOrderCount();
	int TActiveOrderCount();
	decimal TLastOrderPrice();
	decimal TTodayTotalPrice();
}