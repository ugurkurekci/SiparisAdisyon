using System.ComponentModel.DataAnnotations;

namespace SiparisAdisyon.Entity.Models;

public record City
{

    [Key]
    public int Id { get; set; }

    public string Name { get; set; }

    public ICollection<Company> Company { get; set; }

}