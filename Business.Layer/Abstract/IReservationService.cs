namespace Business.Layer.Abstract;
public interface IReservationService:IGenericService<Reservation>
{
	void TReservationStatusApproved(int id);
	void TReservationStatusCanceled(int id);
}