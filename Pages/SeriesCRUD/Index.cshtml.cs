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
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Serie> Serie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Serie != null)
            {
                Serie = await _context.Serie.ToListAsync();
            }
        }
    }
}
