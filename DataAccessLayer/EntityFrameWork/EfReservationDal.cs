namespace DataAccessLayer.EntityFrameWork;
public class EfReservationDal : GenericRepository<Reservation>, IReservationDal
{
	public EfReservationDal(AppDbContext appDbContext) : base(appDbContext){}
	public void ReservationStatusApproved(int id)
	{
		using var context = new AppDbContext();
		var values = context.Reservations.Find(id);
		values.Description = "Rezervasyon Onaylandı";
		context.SaveChanges();
	}
	public void ReservationStatusCanceled(int id)
	{
		using var context = new AppDbContext();
		var values = context.Reservations.Find(id);
		values.Description = "Rezervasyon İptal Edildi";
		context.SaveChanges();
	}
}