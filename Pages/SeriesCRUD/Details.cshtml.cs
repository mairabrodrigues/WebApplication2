using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NetFlex2.Models;
using WebApplication2.Data;

namespace NetFlex2.Pages.SeriesCRUD
{
    public class DetailsModel : PageModel
    {
        private readonly WebApplication2.Data.ApplicationDbContext _context;

        public DetailsModel(WebApplication2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Serie Serie { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Serie == null)
            {
                return NotFound();
            }

            var serie = await _context.Serie.FirstOrDefaultAsync(m => m.IdShow == id);
            if (serie == null)
            {
                return NotFound();
            }
            else 
            {
                Serie = serie;
            }
            return Page();
        }
    }
}
