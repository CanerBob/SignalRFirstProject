using System.ComponentModel.DataAnnotations.Schema;
namespace Models.Layer.Entities;
public class Order
{
	public int OrderId { get; set; }
	public string TableNumber { get; set; }
	public string Description { get; set; }
	[Column(TypeName ="Date")]
	public DateTime Date { get; set; }
	public decimal TotalPrice { get; set; }
    public List<OrderDetails> OrderDetails { get; set; }
}