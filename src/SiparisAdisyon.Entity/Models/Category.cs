using SiparisAdisyon.Core.Entity;
using System.ComponentModel.DataAnnotations;

namespace SiparisAdisyon.Entity.Models;

public class Category:IEntity
{

    [Key]
    public int Id { get; set; }

    public string Name { get; set; }

    public List<MenuItem> MenuItems { get; set; }

}