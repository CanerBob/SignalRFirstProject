namespace Business.Layer.Concrate;
public class OrderDetailManager : IOrderDetailService
{
	private readonly IOrderDetailDal _orderDetailDal;
	public OrderDetailManager(IOrderDetailDal orderDetailDal)
	{
		_orderDetailDal = orderDetailDal;
	}
	public void TAdd(OrderDetails entity)
	{
		_orderDetailDal.Add(entity);
	}
	public void TDelete(OrderDetails entity)
	{
		_orderDetailDal.Delete(entity);
	}
	public List<OrderDetails> TGetAllList()
	{
		return _orderDetailDal.GetAllList();
	}
	public OrderDetails TGetById(int id)
	{
		return _orderDetailDal.GetById(id);
	}
	public void TUpdate(OrderDetails entity)
	{
		_orderDetailDal.Update(entity);
	}
}