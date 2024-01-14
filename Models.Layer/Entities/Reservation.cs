using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Layer.Entities;
public class Reservation
{
    public int ReservationId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Phone { get; set; }
    public string Mail { get; set; }
    public int PersonCount { get; set; }
	[Column(TypeName = "Date")]
	public DateTime Date { get; set; }
}