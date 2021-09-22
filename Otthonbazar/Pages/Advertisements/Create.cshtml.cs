using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Otthonbazar.Data;

namespace Otthonbazar.Pages.Advertisements
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly Otthonbazar.Data.ApplicationDbContext _context;

        public CreateModel(Otthonbazar.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CityId"] = new SelectList(_context.Cities, "Id", "Name");
            return Page();
        }

        [BindProperty]
        public Advertisement Advertisement { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            City city = _context.Cities.FirstOrDefault(c => c.Zip == Advertisement.City.Zip);
            Advertisement.City = city;

            _context.Advertisements.Add(Advertisement);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

        //ezzel a sorral hívódik:
        //$.get("/Advertisements/Create?handler=Iranyitoszam&iranyitoszam=" + event.currentTarget.value).then(function
        public ActionResult OnGetIranyitoszam(int iranyitoszam) {
            return new JsonResult(_context.Cities.FirstOrDefault(c => c.Zip == iranyitoszam.ToString()));
        }
    }
}