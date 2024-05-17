using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiparisAdisyon.Entity.Models;

public record Table
{

    [Key]
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string UniqueNumber { get; set; }

    [ForeignKey("CompanyId")]
    public Company Company { get; set; }

}