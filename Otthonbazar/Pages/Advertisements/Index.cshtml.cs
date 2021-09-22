using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Otthonbazar.Data;
using Otthonbazar.Models;

namespace Otthonbazar.Pages.Advertisements
{
    public class IndexModel : PageModel
    {
        private readonly Otthonbazar.Data.ApplicationDbContext _context;

        [BindProperty(SupportsGet = true)]
        public SearchModel Search { get; set; }

        public IndexModel(Otthonbazar.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Advertisement> Advertisement { get;set; }

        public async Task OnGetAsync()
        {
            Advertisement = await _context.Advertisements
                .Include(a => a.City).ToListAsync();

            IQueryable<Advertisement> advertisements = _context.Advertisements.Include(a => a.City);

            if (Search.CityName != null)
                advertisements = advertisements.Where(a => a.City.Name.Equals(Search.CityName));

            if (Search.PriceMin != null)
                advertisements = advertisements.Where(a => a.Price >= Search.PriceMin.Value);
            if (Search.PriceMax != null)
                advertisements = advertisements.Where(a => a.Price <= Search.PriceMax.Value);

            if (Search.SizeMin != null)
                advertisements = advertisements.Where(a => a.Size >= Search.SizeMin.Value);
            if (Search.SizeMax != null)
                advertisements = advertisements.Where(a => a.Size <= Search.SizeMax.Value);

            if (Search.RoomMin != null)
                advertisements = advertisements.Where(a => a.Room >= Search.RoomMin.Value);
            if (Search.RoomMax != null)
                advertisements = advertisements.Where(a => a.Room <= Search.RoomMax.Value);

            Advertisement = await advertisements.ToListAsync();
        }
    }
}
