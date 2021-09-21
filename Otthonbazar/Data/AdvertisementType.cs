using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Otthonbazar.Data {
    public enum AdvertisementType {
        [Display(Name = "Lakás")]
        Flat,
        [Display(Name = "Ház")]
        House,
        [Display(Name = "Nyaraló")]
        HolidayHouse,
        [Display(Name = "Építési telek")]
        BuildingPlot
    }
}
