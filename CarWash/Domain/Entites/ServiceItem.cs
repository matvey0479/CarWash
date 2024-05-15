using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace CarWash.Domain.Entites
{
    public class ServiceItem
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Заполните название услуги")]
        [Display(Name = "Название услуги")]
        public string Title { get; set; }
        [Display(Name = "Описание услуги")]
        public string Description { get; set; }
        [Display(Name ="Цена")]
        public string Price { get; set; }


    }

}
