namespace Business.Layer.Concrate;
public class ReservationManager : IReservationService
{
	private readonly IReservationDal _reservationDal;

	public ReservationManager(IReservationDal reservationDal)
	{
		_reservationDal = reservationDal;
	}
	public void TAdd(Reservation entity)
	{
		_reservationDal.Add(entity);
	}
	public void TDelete(Reservation entity)
	{
		_reservationDal.Delete(entity);
	}
	public List<Reservation> TGetAllList()
	{
		return _reservationDal.GetAllList();
	}
	public Reservation TGetById(int id)
	{
		return _reservationDal.GetById(id);
	}
	public void TReservationStatusApproved(int id)
	{
		_reservationDal.ReservationStatusApproved(id);
	}
	public void TReservationStatusCanceled(int id)
	{
		_reservationDal.ReservationStatusCanceled(id);
	}
	public void TUpdate(Reservation entity)
	{
		_reservationDal.Update(entity);
	}
}