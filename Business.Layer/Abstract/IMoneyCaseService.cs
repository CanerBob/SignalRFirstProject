namespace Business.Layer.Abstract;
public interface IMoneyCaseService:IGenericService<MoneyCase>
{
	decimal TTotalMoneyCaseAmount();
}
