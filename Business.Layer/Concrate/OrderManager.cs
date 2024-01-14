﻿namespace Business.Layer.Concrate;
public class OrderManager : IOrderService
{
	private readonly IOrderDal _orderDal;
	public OrderManager(IOrderDal orderDal)
	{
		_orderDal = orderDal;
	}
	public decimal TLastOrderPrice()
	{
		return _orderDal.LastOrderPrice();	
	}
	public int TActiveOrderCount()
	{
		return _orderDal.ActiveOrderCount();
	}
	public void TAdd(Order entity)
	{
		_orderDal.Add(entity);
	}
	public void TDelete(Order entity)
	{
		_orderDal.Delete(entity);
	}
	public List<Order> TGetAllList()
	{
		return _orderDal.GetAllList();
	}
	public Order TGetById(int id)
	{
		return _orderDal.GetById(id);
	}
	public int TTotalOrderCount()
	{
		return _orderDal.TotalOrderCount();
	}
	public void TUpdate(Order entity)
	{
		_orderDal.Update(entity);
	}
	public decimal TTodayTotalPrice()
	{
		return _orderDal.TodayTotalPrice();
	}
}