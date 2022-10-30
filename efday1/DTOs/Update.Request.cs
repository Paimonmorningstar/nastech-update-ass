using System.ComponentModel.DataAnnotations;

namespace efday1.DTOs
{
    public class UpdateRequest
    {
        [Required]
        [StringLength(69)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(69)]
        public string LastName { get; set; } = null!;

        [Required]
        public string City { get; set; } = null!;

        [Required]
        public string State { get; set; } = null!;
    }
}