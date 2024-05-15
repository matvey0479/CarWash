using System.ComponentModel.DataAnnotations;
using CarWash.Domain;
namespace CarWash.Domain.Entites
{
    public class Appointment
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Display(Name ="Дата и время")]
        public TakenTime time { get; set; }

        [Display(Name ="Клиент")]
        public Client Client { get; set; }

        [Display(Name = "Услуга")]
        public ServiceItem ServiceItem { get; set; }


    }
}
