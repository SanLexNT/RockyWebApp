using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RockyWebApp.Models
{
    public class ApplicationType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DisplayName("Тип апликации")]
        [Required(ErrorMessage = "Тип апликации не может быть пустым!")]
        public string Name { get; set; }
    }
}
