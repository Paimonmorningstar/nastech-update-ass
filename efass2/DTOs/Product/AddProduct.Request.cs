using System.ComponentModel.DataAnnotations;

namespace efass2.DTOs.Product;

public class AddProductRequest
{
    [Required]
    [StringLength(169)]
    public string Name { get; set; } = null!;
    [Required]
    [StringLength(69)]
    public string Manufacture { get; set; } = null!;
    [Required]
    public int CategoryId { get; set; }
}
