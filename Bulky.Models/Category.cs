using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bulky.Models;

public class Category
{
    [Key]
    public int Id { get; set; }
    [DisplayName("Category Name")]
    [Required]
    [MaxLength(30,ErrorMessage = "max length is 30 letters")]
    [MinLength(2,ErrorMessage = "min length is 2 letters")]
    public string Name { get; set; }
    [DisplayName("Display Order")]
    [Range(1,100,ErrorMessage = "The Value must be between 1 and 100")]
    public int DisplayOrder { get; set; }
}