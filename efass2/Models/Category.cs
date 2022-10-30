using System.ComponentModel.DataAnnotations;

namespace efass2.Models;

public class Category : BaseEntity<int>
{
    [Required]
    [StringLength(169)]
    public string CategoryName { get; set; } = null;
    public ICollection<Product> Products { get; set; } = null;
}
