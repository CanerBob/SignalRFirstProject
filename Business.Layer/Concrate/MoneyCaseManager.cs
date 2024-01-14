namespace Business.Layer.Concrate;
public class MoneyCaseManager : IMoneyCaseService
{
	private readonly IMoneyCaseDal _moneyCaseDal;

	public MoneyCaseManager(IMoneyCaseDal moneyCaseDal)
	{
		_moneyCaseDal = moneyCaseDal;
	}

	public void TAdd(MoneyCase entity)
	{
		throw new NotImplementedException();
	}

	public void TDelete(MoneyCase entity)
	{
		throw new NotImplementedException();
	}

	public List<MoneyCase> TGetAllList()
	{
		throw new NotImplementedException();
	}

	public MoneyCase TGetById(int id)
	{
		throw new NotImplementedException();
	}

	public decimal TTotalMoneyCaseAmount()
	{
		return _moneyCaseDal.TotalMoneyCaseAmount();	
	}

	public void TUpdate(MoneyCase entity)
	{
		throw new NotImplementedException();
	}
}
