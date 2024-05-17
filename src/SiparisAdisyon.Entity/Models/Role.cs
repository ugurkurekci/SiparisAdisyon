using System.ComponentModel.DataAnnotations;

namespace SiparisAdisyon.Entity.Models;

public class Role
{

    [Key]
    public int Id { get; set; }

    public string Name { get; set; }

    public ICollection<Auth> Auths { get; set; }

}