using System.ComponentModel.DataAnnotations;
namespace Models.Layer.Entities;
public class MoneyCase
{
    [Key]
    public int MoneyCaseID { get; set; }
    public decimal TatolAmount { get; set; }
}