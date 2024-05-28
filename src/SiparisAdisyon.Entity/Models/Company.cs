using SiparisAdisyon.Core.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiparisAdisyon.Entity.Models;

public class Company : IEntity
{

    [Key]
    public int Id { get; set; }

    public int CityId { get; set; }

    public bool IsActive { get; set; }

    public string Name { get; set; }

    public string Address { get; set; }

    public string Phone { get; set; }

    public string OptionalPhone { get; set; }

    public string Email { get; set; }

    [ForeignKey("CityId")]
    public City City { get; set; }

    public ICollection<Table> Table { get; set; }

    public ICollection<Auth> Auths { get; set; }

    public ICollection<MenuItem> MenuItems { get; set; }

}