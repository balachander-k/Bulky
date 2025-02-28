using System.ComponentModel.DataAnnotations;

namespace Bulky.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name="Category Name")]
        public string Name { get; set; }
        [Display(Name="Display Order")]
        public int DisplayOrder { get; set; }
    }
}
