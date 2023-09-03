using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServideID { get; set; }

        [Required(ErrorMessage ="Hizmet ikon linki giriniz")]
        public string ServicesIcon { get; set; }

        [Required(ErrorMessage = "Hizmet başlığı giriniz")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Hizmet açıklaması giriniz")]
        public string Description { get; set; }
    }
}
