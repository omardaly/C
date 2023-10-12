#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; // new import for
namespace LoginRegisterProject.Models;


public class User
{
    //User ID
    [Key]
    public int UserId { get; set; }

    //User Name
    [Required(ErrorMessage = "Please enter your username")]
    [MinLength(3, ErrorMessage = "please entre Valid username")]
    public string Username { get; set; }
    //Lucky Number
    [Required(ErrorMessage = "Please enter your lucky number.")]
    [Range(0, int.MaxValue, ErrorMessage = "Please enter a valid number.")]
    [Display(Name = "Lucky Number ")]
    public int LuckyNumber { get; set; }
    // Email
    [Required(ErrorMessage = "Please enter your Email")]
    [EmailAddress(ErrorMessage = "please entre Valid Email")]
    public string Email { get; set; }
    //  Password
    [Required(ErrorMessage = "Please enter Password ")]
    [DataType(DataType.Password)]
    [MinLength(6, ErrorMessage = "Please entre a valid Password")]
    public string Password { get; set; }
    // confirm Password
    [NotMapped]
    [Required(ErrorMessage = " Password must match")]
    [Compare("Password", ErrorMessage = "Password must match.")]
    [DataType(DataType.Password)] // useful
    [Display(Name = "Confirm Password ")]

    public string ConfirmPassword { get; set; }
    //Is Subscribed ?
    [Required(ErrorMessage = "Please enter Password ")]
    public bool IsSubscribed { get; set; }
    //Created At
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    //Updated AT
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

}