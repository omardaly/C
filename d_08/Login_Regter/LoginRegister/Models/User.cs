#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LoginRegister.Models;
public class User
{
    [Key]
    public int UserId { get; set; }
    [Required(ErrorMessage = "Please enter your name")]
    [MinLength(2, ErrorMessage = "please entre Valid name")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Please enter your name")]
    [MinLength(2, ErrorMessage = "please entre Valid name")]
    public string LastName { get; set; }
    [Required(ErrorMessage = "Please enter your Email")]
    [EmailAddress(ErrorMessage = "please entre Valid Email")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Please enter Password")]
    [DataType(DataType.Password)]
    [MinLength(8, ErrorMessage = "Please entre a valid Password")]
    public string Password { get; set; }
    [NotMapped]
    [Required(ErrorMessage = "Password must match")]
    [Compare("Password", ErrorMessage = "Password must match")]
    [Display(Name = "Confirm Password")]
    public string ConfirmPassword { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}