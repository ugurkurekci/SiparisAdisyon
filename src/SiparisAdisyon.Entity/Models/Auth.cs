using SiparisAdisyon.Core.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiparisAdisyon.Entity.Models;

public class Auth : IEntity
{

    [Key]
    public int Id { get; set; }

    public int RoleId { get; set; }

    public int CompanyId { get; set; }

    public bool IsActive { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }

    public string FullName { get; set; }

    public string Email { get; set; }

    public string Phone { get; set; }

    public byte[] PasswordHash { get; set; }

    public byte[] PasswordSalt { get; set; }

    public DateTime CreatedDate { get; set; }

    [ForeignKey("RoleId")]
    public Role Role { get; set; }

    [ForeignKey("CompanyId")]
    public Company Company { get; set; }

    public List<Order> Orders { get; set; }

}