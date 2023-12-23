using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RockyWebApp.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DisplayName("Категория")]
        [Required(ErrorMessage = "Название категории не может быть пустым!")]
        public string Name { get; set; }

        [DisplayName("Порядок вывода")]
        [Required(ErrorMessage = "Порядок вывода не может быть пустым!")]
        [Range(1, int.MaxValue, ErrorMessage = "Порядок вывода должен быть больше 0!")]
        public int DisplayOrder { get; set; }
    }
}
