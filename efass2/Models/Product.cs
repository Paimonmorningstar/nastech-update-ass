using System.ComponentModel.DataAnnotations;
namespace efass2.Models;

    public class Product : BaseEntity<int>
    {
        
    [Required]
    [StringLength(169)]
    public string ProductName { get; set; } = null!;
    [Required]
    [StringLength(69)]
    public string Manufacture { get; set; } = null!;
    [Required]
    public int CategoryId { get; set; }
    public Category? Category { get; set; }
    }
