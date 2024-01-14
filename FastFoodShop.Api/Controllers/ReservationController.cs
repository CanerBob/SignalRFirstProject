namespace FastFoodShop.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ReservationController : ControllerBase
{
	private readonly IReservationService _reservationService;

	public ReservationController(IReservationService reservationService)
	{
		_reservationService = reservationService;
	}
	[HttpGet]
	public IActionResult GetReservation()
	{
		var values = _reservationService.TGetAllList();
		return Ok(values);
	}
	[HttpPost]
	public IActionResult AddReservation(CreateReservationDto model)
	{
		Reservation reservation = new Reservation()
		{
			Date = model.Date,
			Mail = model.Mail,
			Name = model.Name,
			PersonCount = model.PersonCount,
			Phone = model.Phone,
			Description=model.Description
		};
		_reservationService.TAdd(reservation);
		return Ok(reservation);
	}
	[HttpDelete("{id}")]
	public IActionResult DeleteReservation(int id)
	{
		var value = _reservationService.TGetById(id);
		_reservationService.TDelete(value);
		return Ok("Reservasyon Silme İşlemi Başarılı");
	}
	[HttpPut]
	public IActionResult UpdateReservation(UpdateReservationDto model)
	{
		Reservation reservation = new Reservation()
		{
			ReservationId = model.ReservationId,
			Date = model.Date,
			Mail = model.Mail,
			Name = model.Name,
			PersonCount = model.PersonCount,
			Phone = model.Phone,
		};
		_reservationService.TUpdate(reservation);
		return Ok("Rezervasyon Güncellendi");
	}
	[HttpGet("{id}")]
	public IActionResult GetReservation(int id)
	{
		var value = _reservationService.TGetById(id);
		return Ok(value);
	}
	[HttpGet("ReservationStatusApproved")]
	public IActionResult ReservationStatusApproved(int id) 
	{
		_reservationService.TReservationStatusApproved(id);
		return Ok("Rezervasyon Açıklaması Değiştirildi");
	}
	[HttpGet("ReservationStatusCanceled")]
	public IActionResult ReservationStatusCanceled(int id)
	{
		_reservationService.TReservationStatusCanceled(id);
		return Ok("Rezervasyon Açıklaması Değiştirildi");
	}
}