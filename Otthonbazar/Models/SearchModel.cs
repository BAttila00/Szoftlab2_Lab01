using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Otthonbazar.Models {
    public class SearchModel {
        [Display(Name = "Város Id")]
        public int? CityId { get; set; }
        [Display(Name = "Város név")]
        public string CityName { get; set; }
        [Display(Name = "Maximum ár")]
        public decimal? PriceMax { get; set; }
        [Display(Name = "Minimum ár")]
        public decimal? PriceMin { get; set; }
        [Display(Name = "Szobák maximum száma")]
        public int? RoomMax { get; set; }
        [Display(Name = "Szobák minimum száma")]
        public int? RoomMin { get; set; }
        [Display(Name = "Maximális méret")]
        public int? SizeMax { get; set; }
        [Display(Name = "Minimális méret")]
        public int? SizeMin { get; set; }
    }
}
