using System.ComponentModel.DataAnnotations;

public class UpdateProductRequest
{
    [Required]
    public int Id { get; set; }
    [Required]
    [StringLength(169)]
    public string Name { get; set; } = null!;
    [Required]
    [StringLength(69)]
    public string Manufacture { get; set; } = null!;
    [Required]
    public int CategoryId { get; set; }
}
