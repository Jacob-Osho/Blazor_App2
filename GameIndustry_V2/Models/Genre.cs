using System.ComponentModel.DataAnnotations;

namespace GameIndustry_V2.Models
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
