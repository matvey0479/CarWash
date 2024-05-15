using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarWash.Domain.Entites
{
    public class TakenTime
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Required(ErrorMessage = "Введите id")]
        public int Id { get; set; }
        [Display(Name = "Дата")]
        public DateOnly Date { get; set; }
        [Display(Name = "Время")]
        public TimeOnly Time { get; set; }
    }
}
