using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager.Models
{
    [Table("Tasks")]
    public class TaskModel
    {
        [Key]
        public int TaskId { get; set; }
        [DisplayName("Name of the task")]
        [Required(ErrorMessage = "The Name field is required.")]
        [MaxLength(50)]
        public string Name { get; set; }
        [DisplayName("Description of the task")]
        [MaxLength(2000)]
        public string Description { get; set; }
        public bool Done { get; set; }

    }
}
