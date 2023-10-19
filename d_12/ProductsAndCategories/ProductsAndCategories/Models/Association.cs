#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace ProductsAndCategories.Models;
public class Association
{
    [Key]
    public int AssociationId { get; set; }
    [Required]
    public int CategoryId { get; set; }
    [Required]
    public int ProductId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    // - Navigation Properties 
    public Category? Category { get; set; }
    public Product? Product { get; set; }
}