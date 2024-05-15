using System.ComponentModel.DataAnnotations;

namespace CarWash.Domain.Entites
{
    public class Client
    {
        [Key]
        [Required]
        public int Id { get; set; } 
        [Required(ErrorMessage ="Введите номер телефона")]
        [Display(Name = "Номер телефона")]
        public string PhoneNumper { get; set; }
        [Display(Name = "Имя")]
        public string Name { get; set; }

  
    }
}
