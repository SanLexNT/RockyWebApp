using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RockyWebApp.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Наименование продукта не может быть пустым!")]
        public string Name { get; set; }
        public string Description { get; set; }

        [Range(1, double.MaxValue, ErrorMessage = "Цена должна быть больше 0!")]
        [Required(ErrorMessage = "Цена не может быть пустой!")]
        public double Price { get; set; }
        public string Image { get; set; }

        [DisplayName("Категория")]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }
}
