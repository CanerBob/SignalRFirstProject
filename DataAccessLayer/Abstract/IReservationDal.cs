namespace DataAccessLayer.Abstract;
public interface IReservationDal:IGenericDal<Reservation>
{
	void ReservationStatusApproved(int id);
	void ReservationStatusCanceled(int id);
}