using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiparisAdisyon.Entity.Models;

public class MenuItem
{

    [Key]
    public int Id { get; set; }

    public int CategoryId { get; set; }

    public int CompanyId { get; set; }

    public decimal Price { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    [ForeignKey("CompanyId")]
    public Company Company { get; set; }

    [ForeignKey("CategoryId")]
    public Category Category { get; set; }

    public List<OrderItem> OrderItems { get; set; }

}