namespace Business.Layer.Concrate;
public class DiscountManager : IDiscountService
{
	private readonly IDiscountDal _discountDal;
	public DiscountManager(IDiscountDal discountDal)
	{
		_discountDal = discountDal;
	}
    public void TChangeStatusToFalse(int id)
    {
        _discountDal.ChangeStatusFalse(id);	
    }
    public void TChangeStatusToTrue(int id)
    {
        _discountDal.ChangeStatusTrue(id);
    }
    public void TAdd(Discount entity)
	{
		_discountDal.Add(entity);
	}
	public void TDelete(Discount entity)
	{
		_discountDal.Delete(entity);
	}
	public List<Discount> TGetAllList()
	{
		return _discountDal.GetAllList();
	}
	public Discount TGetById(int id)
	{
		return _discountDal.GetById(id);
	}
	public void TUpdate(Discount entity)
	{
		_discountDal.Update(entity);
	}
	public List<Discount> TGetListByStatusTrue()
	{
		return _discountDal.GetListByStatusTrue();
	}
}