using System.ComponentModel.DataAnnotations;

namespace efass2.DTOs.Category;

public class UpdateCategoryRequest
{
    [Required]
    public int Id { get; set; }
    [Required]
    [StringLength(100)]
    public string Name { get; set; } = null!;
}
