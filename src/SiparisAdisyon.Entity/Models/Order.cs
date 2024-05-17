using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiparisAdisyon.Entity.Models;

public class Order
{

    [Key]
    public int Id { get; set; }

    public int AuthId { get; set; }

    public int TableId { get; set; }

    public decimal TotalAmount { get; set; }

    public bool IsApproval { get; set; }

    public DateTime OrderDate { get; set; }

    [ForeignKey("TableId")]
    public Table Table { get; set; }

    [ForeignKey("AuthId")]
    public Auth Auth { get; set; }

    public List<OrderItem> OrderItems { get; set; }

}