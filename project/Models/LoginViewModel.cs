using System.ComponentModel.DataAnnotations;

namespace fls_interview_base_project.Models;

public class LoginViewModel
{
    [Required]
    public string Username { get; set; }

    [Required]
    public string Password { get; set; }
}
