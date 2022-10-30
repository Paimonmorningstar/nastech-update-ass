using System.ComponentModel.DataAnnotations;

namespace efass2.DTOs.Category;

public class AddCategoryRequest
{
    [Required]
    [StringLength(100)]
    public string Name { get; set; } = null!;
}
