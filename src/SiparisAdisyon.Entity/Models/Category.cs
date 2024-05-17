using System.ComponentModel.DataAnnotations;

namespace SiparisAdisyon.Entity.Models;

public class Category
{

    [Key]
    public int Id { get; set; }

    public string Name { get; set; }

    public List<MenuItem> MenuItems { get; set; }

}