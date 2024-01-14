namespace Business.Layer.Abstract;
public interface IDiscountService:IGenericService<Discount>
{
    void TChangeStatusToTrue(int id);
    void TChangeStatusToFalse(int id);
    List<Discount> TGetListByStatusTrue();
}