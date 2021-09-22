using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Otthonbazar.Data {
    public class Advertisement {
        public int Id { get; set; }

        [Display(Name = "Cím")]
        [Required(ErrorMessage = "Kérjük adjon meg címet")]
        public string Address { get; set; }

        [Display(Name = "Építés éve")]
        [Required(ErrorMessage = "Kérjük adjon meg építési dátumot")]
        public int BuildDate { get; set; }

        [Display(Name = "Város")]
        public int CityId { get; set; }

        [Display(Name = "Város")]
        public City City { get; set; }

        [Display(Name = "Leírás")]
        public string Description { get; set; }

        [Display(Name = "Fél szobák")]
        [Required(ErrorMessage = "Kérjük adja meg a fél szobák számát")]
        public int HalfRoom { get; set; }

        [Display(Name = "Fénykép")]
        public string ImageUrl { get; set; }

        [Display(Name = "Eladási ár")]
        [Required(ErrorMessage = "Kérjük adjon meg eladási árat")]
        public decimal Price { get; set; }

        [Display(Name = "Szobák")]
        [Required(ErrorMessage = "Kérjük adja meg a szobák számát")]
        public int Room { get; set; }

        [Display(Name = "Alapterület")]
        [Required(ErrorMessage = "Kérjük adja meg az ingatlan alapterületét")]
        public int Size { get; set; }

        [Display(Name = "Típus")]
        [Required(ErrorMessage = "Kérjük adja meg az ingatlan típusát")]
        public AdvertisementType AdvertisementType { get; set; }

    }
}
