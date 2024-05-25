namespace SiparisAdisyon.Business.Dtos.Auths;

public class RegisterDto
{

    public int RoleId { get; set; }

    public int CompanyId { get; set; }

    public bool IsActive { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }

    public string FullName { get; set; }

    public string Email { get; set; }

    public string Phone { get; set; }

    public DateTime CreatedDate { get; set; }

}