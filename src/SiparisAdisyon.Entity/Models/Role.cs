using SiparisAdisyon.Core.Entity;
using System.ComponentModel.DataAnnotations;

namespace SiparisAdisyon.Entity.Models;

public class Role : IEntity
{

    [Key]
    public int Id { get; set; }

    public string Name { get; set; }

    public ICollection<Auth> Auths { get; set; }

}